using System;

namespace PlayersGuideChapter19
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball bigRed = new Ball(5, new Color(255, 0, 0));
            Ball littleBlue = new Ball(1, new Color(0, 0, 255));

            bigRed.Throw();
            bigRed.Throw();
            bigRed.Pop();
            bigRed.Throw();

            Console.WriteLine($"The big red ball was thrown {bigRed.GetThrown()} times");
            Console.ReadKey();
        }
    }
}
