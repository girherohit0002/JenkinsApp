using NUnit.Framework;
using MyMaths;

namespace JenkinAppTesting
{
    public class Tests
    {
        Oprations op;

        [SetUp]
        public void Setup()
        {
            op = new Oprations();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Add_check()
        {
            int expected = 50;
            int actual = op.Add(10 , 40);

            Assert.AreEqual(expected, actual, "Failed");
        }

        [Test]
        public void Mul_check()
        {
            int expected = 50;
            int actual = op.Multiply(10, 5);

            Assert.AreEqual(expected, actual, "Failed");
        }
    }
}