using System.Collections;
using System;
using System.Text;


/// <summary>
/// reverse of a string with or without using length -1
/// </summary>

namespace algorithams
{
    public static class Strings
    {
        /// <summary>
        /// with for loop
        /// </summary>
        /// <returns></returns>
        
        public static string ReverseString()
        {
            string s = "love";
            StringBuilder reversStr = new StringBuilder();
            for(int i=s.Length-1; i>=0; i--)
            {
                reversStr.Append(s[i]);
            }
            return Convert.ToString(reversStr);
        }
        /// <summary>
        ///  wih recursion methods
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        
        public static string ReverseString(string str)
        {
            if(str.Length == 1)
            {
                return str;
            }
            else
            {
                var firstLetter = str[0];
                return ReverseString(str.Substring(1)) + firstLetter;
            }
        }
        /// <summary>
        /// How to Determine if Two Words Are Anagrams of Each Other in C#
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        
        public static bool Anagrams(string str1, String str2)
        {
            char[] char1 = str1.ToLower().ToCharArray();
            char[] char2 = str2.ToLower().ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);
            string NewWord1 = new string(char1);  
            string NewWord2 = new string(char2);  
            if(NewWord1 == NewWord2)
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