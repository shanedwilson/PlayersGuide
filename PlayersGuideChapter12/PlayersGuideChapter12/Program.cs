using System;

namespace PlayersGuideChapter12
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input number of rows for this pattern :");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int space = 1; space <= n - row; space++)
                    Console.Write(" ");
                for (int star = 1; star <= 2 * row - 1; star++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadKey();

            Console.Write("Now it's time for Fizz Buzz. Hit enter to begin.");
            Console.ReadKey();

            for (int i = 1; i <=100; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
