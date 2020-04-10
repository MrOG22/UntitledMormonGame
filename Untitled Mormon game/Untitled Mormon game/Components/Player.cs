using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Untitled_Mormon_game.CommandPattern;

namespace Untitled_Mormon_game.Components
{
    public class Player : Component
    {
        protected Texture2D sprite;
        protected Texture2D[] sprites;

        protected float rotation;
        protected Vector2 origin;
        protected int fps;
        private float timeElapsed;
        private int currentIndex;


        public static float playerPositionX;
        public static float playerPositionY;



        public float rotationVelocity = 3f;
        public float linearVelocity = 4f;
        private Vector2 direction;

        private float speed;
        private Vector2 position;
        private Vector2 velocity;
        //private Transform transform;

        Follower fol = new Follower();



        public Player(Vector2 startPosition)
        {
            //transform = new Transform();



            this.speed = 100f;
            //this.position.X = transform.Position.X;
            //this.position.Y = transform.Position.Y;
            InputHandler.Instance.Entity = this;
        }

        protected void Animation(GameTime gameTime)
        {

            timeElapsed += (float)gameTime.ElapsedGameTime.TotalSeconds;
            currentIndex = (int)(timeElapsed * fps);
            sprite = sprites[currentIndex];

            if (currentIndex >= sprites.Length - 1)
            {
                timeElapsed = 0;
                currentIndex = 0;
            }
        }


        public override void Awake()
        {
            GameObject.Transform.Position = new Vector2(GameWorld.Instance.GraphicsDevice.Viewport.Width / 2,
            GameWorld.Instance.GraphicsDevice.Viewport.Height / 2);
        }

        public override void Start()
        {

            SpriteRenderer sr = (SpriteRenderer)GameObject.GetComponent("SpriteRenderer");
            sr.SetSprite("WalkUp1");
            sr.Origin = new Vector2(sr.Sprite.Width / 2, (sr.Sprite.Height / 2) + 35);
        }

        public override string ToString()
        {
            return "Player";



        }



        public static Vector2 playerPosition;

        public void Move(Vector2 velocity)
        {
            if (velocity != Vector2.Zero)
            {
                velocity.Normalize();
            }
            playerPositionX = (int)GameObject.Transform.Position.X;
            playerPositionY = (int)GameObject.Transform.Position.Y;


            playerPosition = GameObject.Transform.Position;


            velocity *= speed;

            //Debug.WriteLine("PLAYER" + playerPositionX);
            //Debug.WriteLine("PLAYER" + playerPositionY);


            GameObject.Transform.Translate(velocity * GameWorld.Instance.DeltaTime);

            //Debug.WriteLine(transform.Position);

        }
    }
}