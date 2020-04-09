using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Untitled_Mormon_game.Components;

namespace Untitled_Mormon_game.CommandPattern
{
    class MoveCommand : ICommand
    {
        /// <summary>
        /// The move command's velocity
        /// </summary>
        private Vector2 velocity;

        public MoveCommand(Vector2 velocity)
        {
            //Sets the movecommand's velocity
            this.velocity = velocity;
        }

        /// <summary>
        /// Executes the command
        /// </summary>
        /// <param name="player"></param>
        public void Execute(Player player)
        {
            //player.Move(velocity);
        }
    }
}
