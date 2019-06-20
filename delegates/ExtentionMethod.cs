using System;

namespace delegates
{
    public static class ExtentionMethod
    {
        public static void GlobelExtention(this Object theObj)
        {
            Console.WriteLine("Logging to database");
        }
    }
}