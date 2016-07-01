using Ludo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Models
{
    public abstract class Dice : IDice
    {
        public int MinNum { get; private set; }
        public int MaxNum { get; private set; }

        public Dice(int min, int max)
        {
            this.MinNum = min;
            this.MaxNum = max;
        }

        public int Throw()
        {
            throw new NotImplementedException();
        }
    }
}
