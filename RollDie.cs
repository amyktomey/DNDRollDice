﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDRollDice
{
    class RollDie
    {
        private static Random random = new();
        private int sidesCount;

        public RollDie(int SidesCount = 6)
        {
            sidesCount = SidesCount;
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