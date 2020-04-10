using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Untitled_Mormon_game.CommandPattern;

namespace Untitled_Mormon_game.Components
{
    class Player : Component
    {
        public float rotationVelocity = 3f;
        public float linearVelocity = 4f;
        private float speed;
        private Vector2 velocity;
        private Vector2 position;
        private Transform transform;

        public Player(Vector2 startPosition)
        {
            transform = new Transform();

            transform.Position = startPosition;
            this.speed = 1000f;
            InputHandler.Instance.Entity = this;
            //hej
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

        public void Move(Vector2 velocity)
        {
            position += ((velocity * speed) * GameWorld.DeltaTime);

        }


    }
}
