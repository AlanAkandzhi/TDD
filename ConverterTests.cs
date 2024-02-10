using NUnit.Framework;

namespace Convert.Tests
{
    public class ConverterTests
    {
        [TestCase(1, "mm", 25.4)]
        [TestCase(1, "cm", 2.54)]
        [TestCase(1, "m", 0.0254)]
        public void TestConversion(double inches, string unit, double expected)
        {
            Assert.AreEqual(expected, Converter.ConvertToUnit(inches, unit), 0.001);
        }
    }
}
