using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using imtrying;

namespace LargeProject_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IncreaseTest()
        {

            Player gamer = new Player();

            gamer.Points = 100;

            int a = gamer.Points;
            int b = 100;

            int c = 200;
            gamer.Pointincrease();

            Assert.AreEqual(100+100, gamer.Points);

            Assert.IsTrue(b + 100 == c);

        }
        [TestMethod]
        public void DecreaseTest()
        {

            Player gamer = new Player();

            gamer.Points = 100;

            int a = gamer.Points;
            int b = 100;

            int c = 0;
            gamer.PointDecrease();

            Assert.AreEqual(100 - 100, gamer.Points);

            Assert.IsTrue(b - 100 == c);


        }
        [TestMethod]
        public void CompareTest()
        {

            int a = 10;

            int b = 10;

            

            Assert.AreEqual(a, b);

            Assert.IsTrue(b == a);


        }
    }
}
