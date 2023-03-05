using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public class SuperDigit
    {
        public int superDigit(string n, int k)
        {

            long result = 0;
            int len = n.Length;

            if (len == k)
            {
                k -= 1;
            }

            for (int i = 0; i <= k; i++)
            {
                result += int.Parse(n[i].ToString());

            }

            int newResult = (int)result;

            while (result.ToString().Length != 1)
            {
                string OldResult = result.ToString();

                int resultNew = 0;
                for (int i = 0; i <= result.ToString().Length - 1; i++)
                {
                    resultNew += int.Parse(OldResult[i].ToString());
                }
                result = resultNew;
            }
            return (int)result;
        }
    }
}
