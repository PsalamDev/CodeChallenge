using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public class LonelyInteger
    {

        public static int lonelyinteger(List<int> a)
        {
            var numberGroups = a.GroupBy(i => i);
            foreach (var grp in numberGroups)
            {
                if (grp.Count() == 1)
                {
                    return grp.Key;
                }
            }
            return 0;
        }
    }
}

