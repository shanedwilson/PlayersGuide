 using System;

namespace PlayersGuideChapter11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the type of calculation you would like to do. Select from +, -, *, /, % or ^");
            var calc = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter the first number you would like to use.");
            var x = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number you would like to use.");
            var y = float.Parse(Console.ReadLine());
            float answer;

            switch (calc)
            {
                case '+' :
                    answer = x + y;
                    Console.WriteLine($"Your answer is {answer}");
                    break;

                case '-':
                    answer = x - y;
                    Console.WriteLine($"Your answer is {answer}");
                    break;

                case 'x':
                    answer = x * y;
                    Console.WriteLine($"Your answer is {answer}");
                    break;

                case '/':
                    answer = x / y;
                    Console.WriteLine($"Your answer is {answer}");
                    break;

                case '%':
                    answer = x % y;
                    Console.WriteLine($"Your answer is {answer}");
                    break;

                case '^':
                    var dblAnswer = Math.Pow(Convert.ToDouble(x), Convert.ToDouble(y));
                    Console.WriteLine($"Your answer is {dblAnswer}");
                    break;
            }
            Console.ReadKey();
        }
    }
}
