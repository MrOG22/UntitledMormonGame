﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untitled_Mormon_game.CommandPattern
{
    interface ICommand
    {
        void Execute(Player player);
    }
}
