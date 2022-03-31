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
        public void Roll()  // return random.Next(1, sidesCount + 1);
        {
            var rollDie = new RollDie(2);
            var result  = rollDie.Roll();
            Assert.AreEqual(result, 2);
        }
        //[TestMethod]
        //public void ToString()  //  return String.Format("Rolling a die with {0} sides", sidesCount);
        //{
        //    var rollDie = new RollDie(6);
        //    var result = string.Format("Rolling a die with {0} sides", rollDie);
        //    Assert.AreEqual(result, 6);
        //}
    }

    internal class TestMethodAttribute : Attribute
    {
    }

    internal class TestClassAttribute : Attribute
    {
    }
}