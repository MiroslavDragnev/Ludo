using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Models
{
    using Ludo.Enumerations;

    public class Player
    {
        private string name;
        private ColorType color;
        private int pawnsAtHome;
        private int pawnsEscaped;
        private int stepsLeft;
        //maybe more fields will be needed...
    }
}
