using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspPerformanceComparison.Data
{
    public static class RandomPayload
    {

        public static string generate(int length)
        {
            Random r = new Random();
            StringBuilder sb = new StringBuilder(length);
            sb.Length = length;
            
            for (int i = 0; i < length; i++)
                sb[i] = (Char)(65 + r.Next(28));

            return sb.ToString();
        }
    }
}
