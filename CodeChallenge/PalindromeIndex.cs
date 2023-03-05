using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{ 
   public class PalindromeIndex
   {
      static int palindromeIndexChallenge(String s)
      {
          
          int result = -1;
          int length = s.Length;

          for (int i = 0; i < length / 2; i++)
          {
             if (s[i] == s[length - 1 - i])
                continue;

            else if (s[i + 1] == s[length - i - 1] && s[i + 2] == s[length - i - 2])
                return i;

            else if (s[i] == s[length - i - 2] && s[i + 1] == s[length - i - 3])
                return length - i - 1;

          }
         return result;
      }
   }
}
