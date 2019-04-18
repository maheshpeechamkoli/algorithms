using System.Collections;
using System;

namespace algorithams
{
   /// <summary>
   /// {1,2,3,2,4,4,5} find out same pairs
   /// </summary>
    public static class SocksAlgorithms
    {
        public static int Socks()
        {
            int[] number = {1,2,3,2,4,4,5,1};
            int count = 0;
            ArrayList arrList = new ArrayList();

            for (int i = 0; i < number.Length; i++)
            {
                if(!arrList.Contains(number[i]))
                {
                    arrList.Add(number[i]);
                }
                else
                {
                    count++;
                    arrList.Remove(number[i]);
                }
            }
            return count;
        }
    
    }
}