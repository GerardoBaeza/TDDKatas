using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKatas.IPtoString
{
    public class IpToStringConverter
    {
        public string UInt32ToIP(uint v)
        {
            if (v > 0)
            {
                StringBuilder builder = new StringBuilder();
                var binary = Convert.ToString(v, 2);
                List<String> octetList = new List<string>();
                octetList.Add(binary.Substring(0, 8));
                octetList.Add(binary.Substring(8, 8));
                octetList.Add(binary.Substring(16, 8));
                octetList.Add(binary.Substring(24, 8));
                foreach (string octet in octetList)
                {
                    builder.Append(Convert.ToInt32(octet, 2));
                    builder.Append(".");
                }

                return builder.ToString().Remove(builder.ToString().Length - 1);
            }
            return "0.0.0.0";
        }
    }
}
