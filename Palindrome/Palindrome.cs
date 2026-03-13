using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

static class Palindrome
{
    public static bool IsPalindrome(this string s)
    {
        if (string.IsNullOrEmpty(s)) return false;
        string origin = s.Trim()
                        .ToUpper()
                        .Replace(",", "")
                        .Replace(":", "")
                        .Replace("?", "");
        char[] strs = origin.ToCharArray();
        char[] rev = strs.Reverse().ToArray();
        for (int i = 0; i < rev.Length; i++)
        {
            if (!(rev[i] == strs[i]))
            {
                return false;
            }
        }
        return true;
    }
}