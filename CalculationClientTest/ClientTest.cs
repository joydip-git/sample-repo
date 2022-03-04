using NUnit.Framework;
using System.IO;
using CalculaulationClient;

namespace CalculationClientTest
{
    public class ClientTest
    {
        StringWriter writer;
        [SetUp]
        public void Setup()
        {
            writer = new StringWriter();
        }

        [Test]
        public void Test1()
        {
            System.Console.SetOut(writer);
            Program.Main();
            var actual = writer.ToString().Trim();
            Assert.AreEqual(5, int.Parse(actual));
        }
    }
}