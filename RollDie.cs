using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDRollDice
{
    class RollDie
    {
        private Random random;
        private int sidesCount;

        public RollDie(int aSidesCount)
        {
            sidesCount = aSidesCount;
            random = new Random();
        }
        public int GetSidesCount()
        {
            return sidesCount;
        }
        public int Roll()
        {
            return random.Next(1, sidesCount + 1);
        }
        public override string ToString()
        {
            return String.Format("Rolling a die with {0} sides", sidesCount);
        }

    }
}