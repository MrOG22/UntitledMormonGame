using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untitled_Mormon_game.CommandPattern
{
    class InputHandler
    {
        /*private float rotationVelocity = 3f;
        private float linearVelocity = 4f;
        private Vector2 direction;
        private float rotation;
        private Vector2 position;*/

        private static InputHandler instance;


        public static InputHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InputHandler();
                }

                return instance;

            }
        }


        public Player Entity { get; set; }


        private Dictionary<Keys, ICommand> keybinds = new Dictionary<Keys, ICommand>();



        public InputHandler()
        {
            keybinds.Add(Keys.A, new MoveCommand(new Vector2(-1, 0)));
            keybinds.Add(Keys.D, new MoveCommand(new Vector2(1, 0)));
            keybinds.Add(Keys.W, new MoveCommand(new Vector2(0, -1)));
            keybinds.Add(Keys.S, new MoveCommand(new Vector2(0, 1)));
            /*
            direction = new Vector2((float)Math.Cos(MathHelper.ToRadians(90) - rotation), -(float)Math.Sin(MathHelper.ToRadians(90) - rotation));
            keybinds.Add(Keys.A, new MoveCommand(new Vector2(rotation -= MathHelper.ToRadians(rotationVelocity))));
            keybinds.Add(Keys.D, new MoveCommand(new Vector2(rotation += MathHelper.ToRadians(rotationVelocity))));
            keybinds.Add(Keys.W, new MoveCommand(position += direction * linearVelocity));
            keybinds.Add(Keys.S, new MoveCommand(position -= direction * linearVelocity));*/
        }


        public void Execute(Player player)
        {
            KeyboardState keyState = Keyboard.GetState();

            foreach (Keys key in keybinds.Keys)
            {
                if (keyState.IsKeyDown(key))
                {
                    keybinds[key].Execute(Entity);
                }
            }
        }
    }
}
