using Ludo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Contracts
{
    interface IPawn
    {
        void Move(IList<Field> playground, IList<Field> finish, int steps, bool moveBack);
    }
}
