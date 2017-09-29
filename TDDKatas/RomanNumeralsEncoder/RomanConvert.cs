using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKatas.RomanNumeralsEncoder
{
    public class RomanConvert
    {
        public string Solution(int value)
        {
            var value1 = new string('I', value);
            var value2 = value1.Replace(new string('I', 1000), "M");
            var value3 = value2.Replace(new string('I', 900), "CM");
            var value4 = value3.Replace(new string('I', 500), "D");
            var value5 = value4.Replace(new string('I', 400), "CD");
            var value6 = value5.Replace(new string('I', 100), "C");
            var value7 = value6.Replace(new string('I', 90), "XC");
            var value8 = value7.Replace(new string('I', 50), "L");
            var value9 = value8.Replace(new string('I', 40), "XL");
            var value10 = value9.Replace(new string('I', 10), "X");
            var value11 = value10.Replace(new string('I', 9), "IX");
            var value12 = value11.Replace(new string('I', 5), "V");
            var value13 = value12.Replace(new string('I', 4), "IV");
            return value13;
        }
    }
}
