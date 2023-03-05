using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge {

    public class ComparisonSorting
    {
        public List<int> countingSort(List<int> arr)
        {
            List<int> res = Enumerable.Repeat(0, 100).ToList();
             
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] < 100)
                {
                    res[arr[i]]++;
                }
            }
            return res;
        }
    }

}

