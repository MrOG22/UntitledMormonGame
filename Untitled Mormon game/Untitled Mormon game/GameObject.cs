using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untitled_Mormon_game
{
    abstract class GameObject
    {
        Texture2D texture;
        Texture2D[] textures;
        Vector2 position;
        float speed;
        Vector2 velocity;
        int fps;
        int currentIndex;


        public abstract void LoadContent(ContentManager content);

        public abstract void Update(GameTime gameTime);

        public void Draw(SpriteBatch spriteBatch)
        {

        }

        protected void Animation(GameTime gameTime)
        {

        }


    }
}
