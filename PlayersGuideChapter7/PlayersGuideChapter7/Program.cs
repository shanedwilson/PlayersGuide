using System;

namespace PlayersGuideChapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an interger.");
            int int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second interger.");
            int int2 = Convert.ToInt32(Console.ReadLine());
            int quotient = int1 / int2;
            int remainder = int1 % int2;
            Console.Write(int1 + "/" + int2 + " is " + quotient + " remainder " + quotient);
            Console.ReadKey();
        }
    }
}
