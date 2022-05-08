using System;

    namespace Summator
    {
          public class Program
           {
              static void Main(string[] args)
               {
            long result = Summator.Sum(new int[] { 1, 2, 3, 4, 5, 6, });
            if (result == 20)
            {
                Console.WriteLine("TEST PASSED");
            }
            else
            {
                Console.WriteLine("TEST FAILED");

            }
            static void Main(string[] args)
            {
                long avergae = Summator.Average(new int[] { 5, 10, 15 });
                if (average == 10)
                {
                    Console.WriteLine("TEST PASSED");
                }
                else
                {
                    Console.WriteLine("TEST FAILED");

                }

            }
    }
}



