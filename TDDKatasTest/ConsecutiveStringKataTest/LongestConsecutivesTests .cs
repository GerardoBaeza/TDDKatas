using System;

using TDDKatas.ConsecutiveStringKata;


namespace TDDKatasTest.ConsecutiveStringKataTest
{
    using NUnit.Framework;
    [TestFixture]
    public class LongestConsecutivesTests
    {
        LongestConsecutives longest= new LongestConsecutives();
        [Test]
        public  void LongestConsecutivestest1()
        {
            var actual= longest.LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2);
            Assert.AreEqual("abigailtheta", actual);
        }
        [Test]
        public  void LongestConsecutivestest2()
        {
            var actual = longest.LongestConsec(new String[] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1);
            Assert.AreEqual("oocccffuucccjjjkkkjyyyeehh", actual);
        }
        [Test]
        public  void LongestConsecutivestest3()
        {
            var actual = longest.LongestConsec(new String[] { "itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck" }, 2);
            Assert.AreEqual("wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck", actual);
        }
        [Test]
        public  void LongestConsecutivestest4()
        {
            var actual = longest.LongestConsec(new String[] { }, 3);
            Assert.AreEqual("", actual);
        }
        [Test]
        public  void LongestConsecutivestest5()
        {
            var actual = longest.LongestConsec(new String[] { "wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu" }, 2);
            Assert.AreEqual("wlwsasphmxxowiaxujylentrklctozmymu", actual);
        }
        [Test]
        public  void LongestConsecutivestest6()
        {
            var actual = longest.LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas" }, -2) ;
            Assert.AreEqual("", actual);
        }
        [Test]
        public  void LongestConsecutivestest7()
        {
            var actual = longest.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 3);
            Assert.AreEqual("ixoyx3452zzzzzzzzzzzz", actual);
        }
        [Test]
        public  void LongestConsecutivestest8()
        {
            var actual = longest.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 15) ;
            Assert.AreEqual("", actual);
        }
        [Test]
        public  void LongestConsecutivestest9()
        {
            var actual=longest.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 0);
            Assert.AreEqual("", actual);
        }

    }
}
