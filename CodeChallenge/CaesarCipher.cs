using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public class CaesarCipher
    {

        public static string caesarCipher(string s, int k)
        {
            char[] charArr = s.ToCharArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                if (Char.IsLetter(charArr[i]))
                {
                    int c = (int)charArr[i];
                    k %= 26;
                    char temp = (char)(c + k);
                    charArr[i] = (Char.IsLetter(temp) && IsSameCase(temp, charArr[i])) ? temp : Convert.ToChar(c + k - 26);
                }
            }
            return new string(charArr);
        }
        public static bool IsSameCase(char a, char b)
        {
            return Char.IsLower(a) && Char.IsLower(b) || Char.IsUpper(a) && Char.IsUpper(b);
        }
    }
}