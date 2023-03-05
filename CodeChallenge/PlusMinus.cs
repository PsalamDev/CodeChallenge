using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public class PlusMinus
    {
        public void plusMinusChallenge(List<int> arr)
        {
            decimal positives = 0;
            decimal negatives = 0;
            decimal zeros = 0;
            decimal length = arr.Count();

            for (int i = 0; i < length; i++)
            {
                if (arr[i] > 0)
                {
                    positives++;
                }

                if (arr[i] < 0)
                {
                    negatives++;
                }

                if (arr[i] == 0)
                {
                    zeros++;
                }
            }
            Console.WriteLine($"{positives / length:F6}");
            Console.WriteLine($"{negatives / length:F6}");
            Console.WriteLine($"{zeros / length:F6}");
        }
    }
}



