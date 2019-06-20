using System;

namespace delegates
{
    public class Palindrome
    {
        public static bool IsPalindrom(string str)                
        {
            int j = str.Length - 1;
            bool flag = false;
            for(int i=0 ; i < (str.Length/2) ; i++)
            {
                if(str[i] == str[j])
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
                j--;
            }
            return flag;
        }               
    }
}