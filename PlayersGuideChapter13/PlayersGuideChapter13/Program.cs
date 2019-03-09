using System;

namespace PlayersGuideChapter13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new[] { 1, 2, 3, 4, 5 };
            int[] array2 = new int[array1.Length];
            int currentMinimum = Int32.MaxValue;
            int total = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i];
                Console.WriteLine(array2[i]);
            }
            Console.ReadKey();

            foreach (int item in array1)
            {
                if (item < currentMinimum)
                    currentMinimum = item;
            }
            Console.WriteLine(currentMinimum);
            Console.ReadKey();

            foreach (int item in array1)
                total += item;
            float average = (float)total / array1.Length;
            Console.WriteLine(average);
            Console.ReadKey();
        }
    }
}
