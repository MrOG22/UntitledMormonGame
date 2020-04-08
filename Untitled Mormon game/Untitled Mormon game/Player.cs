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
        public GameObject GameObject { get; set; }

        public Player(Vector2 position, Texture2D playerTex)
        {
            this.speed = 100;
            this.texture = playerTex;
        }


        public override void LoadContent(ContentManager content)
        {
            throw new NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
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
