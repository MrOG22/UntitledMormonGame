using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Untitled_Mormon_game
{
    class Player : GameObject
    {

        public Player()
        {
            this.speed = 100;
        }


        public override void LoadContent(ContentManager content)
        {
            sprite = content.Load<Texture2D>("player");
        }

        public override void Update(GameTime gameTime)
        {

        }
        public void Move(Vector2 velocity)
        {
            if (velocity != Vector2.Zero)
        {
            velocity.Normalize();
        }

        velocity *= speed;

        //GameObject.Transform.Translate(velocity * GameWorld.Instance.DeltaTime);

        }
    }
}
