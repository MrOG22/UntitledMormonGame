using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untitled_Mormon_game.Components
{
    class Player : Component
    {
        public float rotationVelocity = 3f;
        public float linearVelocity = 4f;
        private Vector2 direction;
        private Transform Transform;
        private float speed;
        private Vector2 position;

        public Player()
        {
            this.speed = 1000f;
        }



        public override void Awake()
        {
            GameObject.Transform.Position = new Vector2(GameWorld.Instance.GraphicsDevice.Viewport.Width / 2,
            GameWorld.Instance.GraphicsDevice.Viewport.Height); ;
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

        public void Move(GameTime gameTime)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            position += ((velocity * speed) * deltaTime);

        }


    }
}
