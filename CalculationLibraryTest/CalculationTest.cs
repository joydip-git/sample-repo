using NUnit.Framework;
using CalculaulationLibrary;

namespace CalculationLibraryTest
{
    [TestFixture]
    public class CalculationTest
    {
        Calculation calculation;
        [SetUp]
        public void Setup()
        {
            calculation = new Calculation();
        }

        [Test]
        public void DivideTest()
        {
            Assert.AreEqual(4, calculation.Divide(12, 3));
        }
    }
}