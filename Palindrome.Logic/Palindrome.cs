using System;

namespace Palindrome.Logic
{
    public class Palindrome
    {
        public bool isPalindrome(string str)
        {
            string[] strRemove = new string[] { ".", " ", "!", ",", "´", "/" };
            foreach (var c in strRemove)
            {
                str = str.Replace(c, string.Empty);
            }

            string strSpaces = str.ToLower();
            char[] nameArray = strSpaces.ToCharArray();
            Array.Reverse(nameArray);
            string reverse = new string(nameArray);

            if (strSpaces.Equals(reverse, StringComparison.OrdinalIgnoreCase))
            {

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
