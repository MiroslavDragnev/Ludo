using Ludo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Extensions
{
    public static class HomeExtensions
    {
        public static Field FindEmptyHomeField(this Home home)
        {
            foreach (var field in home.Fields)
            {
                if (field.HasPawn)
                    continue;

                field.HasPawn = true;
                return field;
            }

            return home.Fields[0];
        }
    }
}
