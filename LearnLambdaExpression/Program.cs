using System;
using System.Threading;

namespace LearnLambdaExpression
{
    public class TestDelegate
    {
        public int Test(Func<int, int, int> handler, int num1, int num2)
        {
            return handler(num1, num2);
        }
    }

    class Program
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Square(int number)
        {
            return number * number;
        }

        static void Main(string[] args)
        {
            // LogMessage("Hello world", Console.WriteLine);
            // SetTimeout("Hello world after 1 second", Console.WriteLine, 1000);

            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;

            Console.WriteLine(multiplier(2));

            Func<int, int> square = number => number * number;
            LogMessage(square(5).ToString(), Console.WriteLine);
            SetTimeout(square(5).ToString(), Console.WriteLine, 3000);

            int a = 1, b = 2;
            Console.WriteLine(new TestDelegate().Test((a, b) =>
            {
                return a + b;
            }, a, b));
        }

        static void LogMessage(string message, Action<string> logger)
        {
            logger(message);
        }

        static void SetTimeout(string message, Action<string> handler, int duration)
        {
            Thread.Sleep(duration);
            handler(message);
        }
    }
}
