using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untitled_Mormon_game.Components
{
    class Follower : Component
    {
        private float speed;
        private Vector2 velocity;
        public Follower(float speed, Vector2 velocity)
        {
            this.speed = speed;
            this.velocity = velocity;
        }

        public override void Update(GameTime gameTime)
        {

        }

        public void Idle()
        {

        }

        public void Follow()
        {

        }

    }
}
