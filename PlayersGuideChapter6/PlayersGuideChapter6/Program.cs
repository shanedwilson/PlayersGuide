using System;

namespace PlayersGuideChapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            byte byte1 = 254;
            short short1 = -32765;
            int int1 = -2145480000;
            long long1 = -4222374000850775800L;
            sbyte sbyte1 = -128;
            ushort ushort1 = 32765;
            uint uint1 = 2145480000;
            ulong unlong1 = 9222374000850775800UL;
            char char1 = 'a';
            float float1 = 1.11111111f;
            double double1 = 2.6666555588887777;
            decimal decimal1 = 1.56m;
            bool bool1 = true;
            string string1 = "Doing this shit.";
            Console.WriteLine($"{string1} {byte1}");
            Console.ReadKey();
        }
    }
}
