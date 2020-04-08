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
    public abstract class GameObject
    {


        protected Texture2D sprite;
        protected Texture2D[] textures;
        protected Vector2 position;
        protected float speed;
        protected Vector2 velocity;
        protected Vector2 rotation;
        protected Vector2 origin;
        protected int fps;
        private int currentIndex;





        public abstract void LoadContent(ContentManager content);

        public abstract void Update(GameTime gameTime);

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, position, null, Color.White, 0, origin, 1, SpriteEffects.None, 1);
        }

        protected void Animation(GameTime gameTime)
        {

        }


    }
}
