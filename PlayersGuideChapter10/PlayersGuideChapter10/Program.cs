using System;

namespace PlayersGuideChapter10
{
    class Program
    {
        static void Main(string[] args)
        //{
        //    Console.WriteLine("Please enter a whole number.");
        //    var userInput = Convert.ToInt16(Console.ReadLine());
        //    var check = userInput % 2;

        //    if (check == 0)
        //    {
        //        Console.WriteLine($"{userInput} is an EVEN number.");
        //    }
        //    if (check == 1)
        //    {
        //        Console.WriteLine($"{userInput} is an ODD number.");
        //    }
        //    Console.ReadKey();
        //}

        {
            Console.WriteLine("Please enter the first number you would like to multiply.");
            var inputA = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter the second number you would like to multiply.");
            var inputB = Convert.ToInt16(Console.ReadLine());

            if (inputA <0 && inputB < 0)
            {
                Console.WriteLine("Your product will be positive.");
            }
            if (inputA > 0 && inputB > 0)
            {
                Console.WriteLine("Your product will be positive.");
            }
            if (inputA < 0 && inputB >0)
            {
                Console.WriteLine("Your product will be negative.");
            }
            if (inputA >0 && inputB < 0)
            {
                Console.WriteLine("Your product will be negative.");
            }
            Console.ReadKey();
         }
    }
}
