using System;
using System.Linq;
using FizzBuzz.ObjectOrientedFizzBuzz;
using FizzBuzz.ObjectOrientedFizzBuzz.EnterpriseEdition;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Precedural FizzBuzz 💩");
            ProceduralFizzBuzz();

            Console.WriteLine("Easy OO-FizzBuzz");
            new EasyFizzBuzz().Execute();

            Console.WriteLine("Mixed style OO-FizzBuz EE");
            new FizzBuzz<int, string>(Enumerable.Range(1, 200),
                new StringMatcher<int>(n => n.ToString(),
                    n => n % 3 == 0 ? "Fizz" : "",
                    n => n % 5 == 0 ? "Buzz" : ""),
                new OloloStringConsoleWriter()).Execute();
            
            Console.WriteLine("FP is best!");
        }
        private static void FizzBuzzFp()
        {
            static Func<int, string> Matcher(Func<int, bool> predicate, string term) =>
                n => predicate(n) ? term : "";

            Enumerable.Range(0, 100)
                .Select(FunctionalFizzBuzz.FizzBuzz.Combine(
                    Matcher(n => n.DividesBy(3), "Fizz"),
                    Matcher(n => n.DividesBy(5), "Buzz"),
                    Matcher(n => n.DividesBy(7), "Hiss")
                ))
                .Iter(Console.WriteLine);
        }

        private static void ProceduralFizzBuzz()
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