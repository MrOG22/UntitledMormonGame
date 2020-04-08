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
    class Follower : GameObject
    {
        private Texture2D followerTex;

        public override void LoadContent(ContentManager content)
        {
            sprite = content.Load<Texture2D>("WalkUP1");
        }

        public override void Update(GameTime gameTime)
        {
        }

        private void Follow()
        {

        }
    }
}
