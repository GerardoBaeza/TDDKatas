using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKatas.ConsecutiveStringKata
{
    public class LongestConsecutives
    {
        public string LongestConsec(string[] strarr, int k)
        {
            if (strarr.Length != 0 && k<strarr.Length)
            {
                int maxLenght = 0;
                int startPoint = 0;
                string finalString = "";
                for (int i = 0; i <= strarr.Length - k; i++)
                {
                    int temporalLenght = 0;
                    for (int j = 0; j <= k - 1; j++)
                    {
                        temporalLenght += strarr[j + i].Length;
                    }
                    if (temporalLenght > maxLenght)
                    {
                        maxLenght = temporalLenght;
                        startPoint = i;
                    }
                }
                if (k != 1)
                {
                    var startPointPivot = startPoint;
                    while (startPointPivot<startPoint+k)
                    { 
                        finalString += strarr[startPointPivot];
                        startPointPivot++;
                    }
                }
                else
                    finalString = strarr[startPoint];
                return finalString;
            }
            else return "";
        }
    }
}
