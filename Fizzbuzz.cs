using System;

namespace algorithams
{
   /// <summary>
   /// Write a program that prints the numbers in the given range. But for multiples of three 
   /// print “Fizz” instead of the number and for the multiples of five print “Buzz”. 
   /// For numbers which are multiples of both three and
   /// five print “FizzBuzz”. Print a new line after each string or number.
   /// </summary>
   
    public static class FizzBuzz
    {
        public static void FizzBuzzResult()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for(int j = 1; j <=n ; j++)
            {
                int a= Convert.ToInt32(Console.ReadLine());
                for(int i=1;i<=a;i++)
                {
                    if (i%15==0)
                        Console.WriteLine("FizzBuzz");
                    else if(i%3==0)
                        Console.WriteLine("Fizz");
                    else if(i%5==0)
                        Console.WriteLine("Buzz");
                    else 
                        Console.WriteLine(i);
                }
            }
        }
    }
}