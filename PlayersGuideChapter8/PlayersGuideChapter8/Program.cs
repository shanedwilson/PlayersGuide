using System;

namespace PlayersGuideChapter8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleae enter your cylinder height.");
            var height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pleae enter your cylinder base radius.");
            var radius = Convert.ToDouble(Console.ReadLine());
            var volume = 3.14 * (radius * radius) * height;
            var surfaceArea = 2 * 3.14 * radius * (radius + height);
            Console.WriteLine("Your cylinder's volume is " + volume + ".");
            Console.WriteLine("Your cylinder's surface area is " + surfaceArea + ".");
            Console.ReadKey();
        }
    }
}
