using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untitled_Mormon_game.Components
{
    class Follower : Component
    {
        private float speed;
        private Vector2 velocity;
        public Vector2 position;


        public Follower(float speed, Vector2 velocity, Vector2 position)
        {
            this.speed = speed;
            this.velocity = velocity;
            this.position = position;

        }

        public override void Update(GameTime gameTime)
        {
            Follow();
        }

        public void Idle()
        {

        }

        public void Follow()
        {
           // Makes the follower move
            GameObject.Transform.Translate(velocity * speed * GameWorld.Instance.DeltaTime);

            // Test 1

            if (position.X < Player.playerPosition.X)
            {
                position.X += speed;
            }

            if (position.Y < Player.playerPosition.Y)
            {
                position.Y += speed;
            }
            if (position.X > Player.playerPosition.X)
            {
                position.X -= speed;
            }
            if (position.Y > Player.playerPosition.Y)
            {
                position.Y -= speed;
            }


            // Test 2

            //Vector2 direction = Player.playerPosition - GameObject.Transform.Position;
            //direction.Normalize();
            //velocity = direction * speed;
            //GameObject.Transform.Position += velocity;


            //Debug.WriteLine(Player.playerPosition);

        }

    }
}
