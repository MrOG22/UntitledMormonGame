using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Untitled_Mormon_game.Components;

namespace Untitled_Mormon_game
{
    class EnemyFactory : Factory
    {
        private static EnemyFactory instance;

        public static EnemyFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EnemyFactory();
                }
                return instance;
            }
        }

        private static Random rnd = new Random();

        public override GameObject Create(string type)
        {
            GameObject go = new GameObject();
            SpriteRenderer sr = new SpriteRenderer();
            go.AddComponent(sr);
            go.Transform.Position = new Vector2(rnd.Next(0, GameWorld.Instance.GraphicsDevice.Viewport.Width), 0);

            switch (type)
            {
                case "Follower":
                    sr.SetSprite("LeftWalk1");
                    go.AddComponent(new Follower(20, Vector2.Zero));
                    break;
            

            }

            return go;
        }
    }
}
