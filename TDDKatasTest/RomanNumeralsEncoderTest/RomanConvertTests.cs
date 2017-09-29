using System;
using NUnit.Framework;
using TDDKatas.RomanNumeralsEncoder;

namespace TDDKatasTest.RomanNumeralsEncoderTest
{
    [TestFixture]
    public class RomanConvertTests
    {
        [TestCase(1, "I")]
        public void Test(int value, string expected)
        {
            RomanConvert converter = new RomanConvert();
            Assert.AreEqual(expected, converter.Solution(value));
        }
        [TestCase(2, "II")]
        public void Test2(int value, string expected)
        {
            RomanConvert converter = new RomanConvert();
            Assert.AreEqual(expected, converter.Solution(value));
        }
        [TestCase(1000, "M")]
        public void Test3(int value, string expected)
        {
            RomanConvert converter = new RomanConvert();
            Assert.AreEqual(expected, converter.Solution(value));
        }
        [TestCase(40, "XL")]
        public void Test5(int value, string expected)
        {
            RomanConvert converter = new RomanConvert();
            Assert.AreEqual(expected, converter.Solution(value));
        }
        [TestCase(3999, "MMMCMXCIX")]
        public void Test4(int value, string expected)
        {
            RomanConvert converter = new RomanConvert();
            Assert.AreEqual(expected, converter.Solution(value));
        }
    }
}
