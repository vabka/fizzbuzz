using System;
using FizzBuzz.ObjectOrientedFizzBuzz.Abstractions;

namespace FizzBuzz.ObjectOrientedFizzBuzz
{
    public class EasyFizzBuzz : IFizzBuzz
    {
        public void Execute()
        {
            const string buzz = "Buzz";
            const string fizz = "Fizz";
            const string fizzBuzz = fizz + buzz;
            static bool NumberDividesBy(int n, int d) => n % d == 0;
            for (var i = 1; i <= 100; i++)
            {
                if (NumberDividesBy(i, 15))
                    Console.WriteLine(fizzBuzz);
                else if (NumberDividesBy(i, 5))
                    Console.WriteLine(buzz);
                else if (NumberDividesBy(i, 3))
                    Console.WriteLine(fizz);
                else
                    Console.WriteLine(i);
            }
        }
    }
}