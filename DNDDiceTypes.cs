using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DNDRollDice
{
       public static class DNDDiceTypes
        {
        
        public static IDictionary<string, int> numberOfSides = new Dictionary<string, int>()
                   {
                {"d4", 4},
                {"d6", 6 },
                {"d8",  8},
                {"d10",  10},
                {"d12",  12},
                {"d20",  20},
                {"Percentage Roll", 100}
            };
        }
}
