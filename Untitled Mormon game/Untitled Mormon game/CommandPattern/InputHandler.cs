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
        private float rotationVelocity = 3f;
        private float linearVelocity = 4f;
        private Vector2 direction;
        private float rotation;
        private Vector2 position;
        /// <summary>
        /// InputHandler's singleton instance
        /// </summary>
        private static InputHandler instance;

        /// <summary>
        /// Property for accessing the inputhandler's singleton
        /// </summary>
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

        /// <summary>
        /// En dictionary, som indeholder alle keybinds og commands
        /// </summary>
        private Dictionary<Keys, ICommand> keybinds = new Dictionary<Keys, ICommand>();



        public InputHandler()
        {
            //Opretter keybinds
            keybinds.Add(Keys.A, new MoveCommand(new Vector2(rotation -= MathHelper.ToRadians(rotationVelocity))));
            keybinds.Add(Keys.D, new MoveCommand(new Vector2(rotation += MathHelper.ToRadians(rotationVelocity))));
            direction = new Vector2((float)Math.Cos(MathHelper.ToRadians(90) - rotation), -(float)Math.Sin(MathHelper.ToRadians(90) - rotation));
            keybinds.Add(Keys.W, new MoveCommand(position += direction * linearVelocity));
            keybinds.Add(Keys.S, new MoveCommand(position -= direction * linearVelocity));
        }

        /// <summary>
        /// Kontrollerer om spilleren trykker på nogle af de gemte keybinds
        /// </summary>
        /// <param name="player">Den eneity vi kontrollerer</param>
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
