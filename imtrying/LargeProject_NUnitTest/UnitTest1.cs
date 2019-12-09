using NUnit.Framework;
using imtrying;

namespace LargeProject_NUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            Player gamer = new Player();

            gamer.Points = 100;

            int a = gamer.Points;
            int b = 100;

            int c = 200;
            gamer.Pointincrease();

            Assert.AreEqual(100 + 100, gamer.Points);

            Assert.True(100 + 100 == gamer.Points);
        }
    }
}