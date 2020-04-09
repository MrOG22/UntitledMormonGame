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
        private Transform transform;
        private float speed;
        private Vector2 position;

        public Player(Vector2 startPosition)
        {
            transform = new Transform();

            transform.Position = startPosition;

            this.speed = 1000f;
            this.position.X = 200;
            this.position.Y = 300;
        }



        public override void Awake()
        {

        }

        public override void Start()
        {

        }

        public override void Update(GameTime gameTime)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {

        }


    }
}
