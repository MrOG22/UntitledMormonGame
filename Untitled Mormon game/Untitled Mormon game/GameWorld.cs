using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Untitled_Mormon_game.CommandPattern;
using Untitled_Mormon_game.Components;

namespace Untitled_Mormon_game
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GameWorld : Game
    {

        private static GameWorld instance;

        public static GameWorld Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameWorld();
                }

                return instance;

            }
        }

        public List<GameObject> gameObjects = new List<GameObject>();
        private Random rnd = new Random();

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Player player;
        private float spawnTime;
        private float cooldown = 5;

        /// <summary>
        /// The Game's deltatime
        /// </summary>
        public float DeltaTime { get; set; }

        public GameWorld()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            GameObject go = new GameObject();

            player = new Player(new Vector2(200,200));

            go.AddComponent(player);

            go.AddComponent(new SpriteRenderer());

            gameObjects.Add(go);

            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Awake();
            }

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            //gameObjects.Add(new Player());
            //gameObjects.Add(new Follower());
            //foreach (GameObject gameObject in gameObjects)
            //{
            //    gameObject.LoadContent(Content);
            //}
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Start();
            }

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            DeltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            InputHandler.Instance.Execute(player);

            // TODO: Add your update logic here

            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Update(gameTime);
            }
            
            SpawnFollower();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here


            spriteBatch.Begin();
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Draw(spriteBatch);
            }
            spriteBatch.End();
            base.Draw(gameTime);
        }


        public void RemoveGameObject(GameObject go)
        {
            gameObjects.Remove(go);
        }

        private void SpawnFollower()
        {
            spawnTime += DeltaTime;

            if (spawnTime >= cooldown)
            {
                GameObject go = FollowerPool.Instance.GetObject();
                go.Transform.Position = new Vector2(rnd.Next(0, GraphicsDevice.Viewport.Width - 50), rnd.Next(0, GraphicsDevice.Viewport.Height - 50));
                gameObjects.Add(go);
                spawnTime = 0;
            }
        }
    }
}
