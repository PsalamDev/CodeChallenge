using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public class MiniMaxSum
    {
        public void miniMaxSumChallenge(List<int> arr)
        { 
            long sum = 0;
            long length = arr.Count();

            for (int i = 0; i < length; i++)
            {
                sum += arr[i];
            }
            int min = arr[0];
            int max = arr[0];

            for (int i = 1; i < length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine((sum - max) + " " +(sum - min));
        }
    }
}