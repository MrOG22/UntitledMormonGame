using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untitled_Mormon_game
{
    public class Transform
    {
        /// <summary>
        /// The transform's position
        /// </summary>
        public Vector2 Position { get; set; }

        /// <summary>
        /// Changes the position based on a translation
        /// </summary>
        /// <param name="translation"></param>
        public void Translate(Vector2 translation)
        {
            if (!float.IsNaN(translation.X) && !float.IsNaN(translation.Y))
            {
                Position += translation;
            }

        }
    }
}
