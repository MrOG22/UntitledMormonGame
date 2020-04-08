using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Untitled_Mormon_game
{
    public abstract class GameObject
    {
        public Transform Transform { get; private set; }



        protected Texture2D texture;
        protected Texture2D[] textures;
        protected Vector2 position;
        protected float speed;
        protected Vector2 velocity;
        protected int fps;
        private int currentIndex;




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
