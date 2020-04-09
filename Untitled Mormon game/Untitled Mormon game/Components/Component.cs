using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untitled_Mormon_game.Components
{
    public abstract class Component
    {
        public bool IsEnabled { get; set; } = true;

        public GameObject GameObject { get; set; }

        public virtual void Awake()
        {
            
        }

        public virtual void Start()
        {

        }

        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {

        }

    }
}
