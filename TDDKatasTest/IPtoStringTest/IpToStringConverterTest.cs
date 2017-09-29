using NUnit.Framework;
using System;
using TDDKatas.IPtoString;

namespace TDDKatasTest.IPtoStringTest
{
    [TestFixture]
    public class Sample_Test
    {
        [Test, Description("Sample Tests")]
        public void Test()
        {
            IpToStringConverter Kata = new IpToStringConverter();
            Assert.AreEqual("128.114.17.104", Kata.UInt32ToIP(2154959208));
            Assert.AreEqual("0.0.0.0", Kata.UInt32ToIP(0));
            Assert.AreEqual("128.32.10.1", Kata.UInt32ToIP(2149583361));
        }
    }
}
