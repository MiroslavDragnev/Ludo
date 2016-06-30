using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Contracts
{
    interface IDice
    {
        int MinNum { get; }
        int MaxNum { get; }

        int Throw();
    }
}
