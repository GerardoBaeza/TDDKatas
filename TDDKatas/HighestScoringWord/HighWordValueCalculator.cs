using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKatas.HighestScoringWord
{
    public class HighWordValueCalculator
    {
        List<char> letterList = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public string High(string s)
        {
            string returnWord = "";
            int maxLenghtDetected=0;
            var stringSplitArray = s.Split(' ').ToList();
            foreach (string eachString in stringSplitArray)
            {
                int wordLetterValue = 0;
                List<char> wordArray = eachString.ToArray().ToList();
                foreach(char letter in wordArray)
                {
                    wordLetterValue += letterList.IndexOf(letter)+1;
                }
                if (wordLetterValue > maxLenghtDetected)
                {
                    maxLenghtDetected = wordLetterValue;
                    returnWord = eachString;
                }

            }
            return returnWord;
        }
    }
}


