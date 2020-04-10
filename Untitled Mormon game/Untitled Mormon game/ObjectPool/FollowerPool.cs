using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untitled_Mormon_game
{
    class FollowerPool : ObjectPool
    {

        private static FollowerPool instance;

        public static FollowerPool Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FollowerPool();
                }
                return instance;
            }
        }

        protected override void Cleanup(GameObject gameObject)
        {

        }

        protected override GameObject Create()
        {
            return EnemyFactory.Instance.Create("Follower");
        }
    }
}
