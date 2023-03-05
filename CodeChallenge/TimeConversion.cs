using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public class TimeConversion
    {
        public static void TimeConversionChallenge(string s)
        {
            DateTime d = DateTime.Parse(s);
            Console.WriteLine("24 Hour Format");
            Console.WriteLine(d.ToString("HH:mm:ss"));
            Console.ReadLine();
        }   
    }
}
