using System;

namespace APP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[1];
            Random rand = new Random();

            for (int x = 0; x < myArray.Length; x++)
            {
                myArray[x] = rand.Next(100);
            }

            for (int x = 0; x < 100; x++)
            {
                if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;

                }

                if (x % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }

                if (x % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    
                }

                else
                {
                    Console.WriteLine($"{x}");
                }

            }
        
            Console.ReadKey();
            Console.ReadLine();
        }
        
    }
}