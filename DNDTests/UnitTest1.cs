using DNDRollDice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DNDTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SidesCountIsNumber()
        {
            var rollDie = new RollDie(6);

            var result = rollDie.GetSidesCount();

            Assert.AreEqual(result, 6);
        }
        [TestMethod]
        public void Roll()
        {
            var rollDie = new RollDie(6);

            int countOfValidRolls = 0;

            for (int i = 1; i <= 100; i++)
            {
                var result = rollDie.Roll();

                if (result >= 1 && result <= 6)
                    countOfValidRolls++;
            }
            Assert.AreEqual(countOfValidRolls, 100);
        }
        [TestMethod]
        public static void StringToString() 
        {
            var expectedString = ("Rolling dice with 20 sides");
            object sidesCount = 20;
            var actualString = ("Rolling dice with {0} sides", sidesCount);
            Assert.AreSame(expectedString, actualString);
        }
    }
}