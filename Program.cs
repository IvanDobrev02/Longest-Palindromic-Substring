using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Palindromic_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LongestPalindrome("abb");

        }
        public static string LongestPalindrome(string s)
        {
            int maxLength = 1;
            var maxLengthStr = "";

            for (int i = 0; i < s.Length; i++)
            {
                //Odd Palindrom
                int L = i; int R = i;
                while (L >= 0 && R < s.Length && s[L] == s[R])
                {
                    if (R - L + 1 > maxLength)
                    {
                        maxLength = R - L + 1;
                        maxLengthStr = s.Substring(L, R - L + 1);
                    }
                    L--;
                    R++;
                }

                //Even Palindrom
                L = i; R = i + 1;
                while (L >= 0 && R < s.Length && s[L] == s[R])
                {
                    if (R - L + 1 > maxLength)
                    {
                        maxLength = R - L + 1;
                        maxLengthStr = s.Substring(L, R - L + 1);
                    }
                    L--;
                    R++;
                }

            }

            if (s.Length == 1)
            {
                maxLengthStr = "" + s[0];
            }
            else if (maxLengthStr.Length == 0)
            {
                maxLengthStr = "" + s[0];
            }

            return maxLengthStr;
        }
    }
}
