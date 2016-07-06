﻿using Ludo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Models.Tokens
{
    public class SleepToken : Token
    {
        public override void DoAction(Player player, Pawn pawn)
        {
            player.IsSleeping = true;
        }
    }
}
