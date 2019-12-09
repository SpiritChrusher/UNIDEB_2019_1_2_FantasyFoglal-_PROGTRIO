using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using imtrying;

namespace LargeProject_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Player gamer = new Player();

            gamer.Points = 100;

            int a = gamer.Points;
            int b = 100;

            int c = 200;
            gamer.Pointincrease();

            Assert.AreEqual(100+100, gamer.Points);

            Assert.IsTrue(b + 100 == c);

         //  Assert.Equals(gamer.Points, c);

        }
    }
}
