using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TDDKatas.HighestScoringWord;

namespace TDDKatasTest.HighestScoringWordTest
{
    [TestClass]
    class WordScoreTest
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("man i need a taxi up to ubud").Returns("taxi");
                yield return new TestCaseData("what time are we climbing up to the volcano").Returns("volcano");
                yield return new TestCaseData("take me to semynak").Returns("semynak");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(string s) => new HighWordValueCalculator().High(s);
    }
}
