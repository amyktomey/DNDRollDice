using DNDRollDice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
        public void IsFoundInDictionary()
        {
            // this list contains the content of the dictionary
            var list = new List<int> { 4, 6, 8, 10, 12, 20, 100 };
            //pulling a result from the dictionary
            int result = list.Find(item => item > 10);
            //checking for a match
            Assert.AreEqual(result, 12);
 
        }
        [TestMethod]
        public void StringToString() 
        {
            var expectedString = "Rolling dice with 20 sides";
            var sidesCount = 20;
            var actualString = $"Rolling dice with {sidesCount} sides";
            Assert.AreEqual(expectedString, actualString);
        }
    }
}