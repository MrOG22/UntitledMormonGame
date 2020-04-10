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


        public static float followerPositionX;
        public static float followerPositionY;


        public Follower(float speed, Vector2 position)
        {
            this.speed = speed;
            this.position = position;
        }

        public Follower()
        {
        }

        float distanceX;
        float distanceY;


        public override void Update(GameTime gameTime)
        {

            distanceX = Player.playerPositionX - GameObject.Transform.Position.X;
            distanceY = Player.playerPositionY - GameObject.Transform.Position.Y;


            if (distanceX <= 20)
            {
                Follow();

                followerPositionX += speed;
            }

            if (distanceY <= 20)
            {
                Follow();

                followerPositionY += speed;
            }
     
        }

        public void Idle()
        {

        }

        public void Follow()
        {


            followerPositionX = GameObject.Transform.Position.X;
            followerPositionY = GameObject.Transform.Position.Y;
      
            Vector2 direction = Player.playerPosition - GameObject.Transform.Position;
            direction.Normalize();
            velocity = direction * speed;
            GameObject.Transform.Position += velocity;

        }

    }
}
