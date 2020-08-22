namespace FizzBuzz
{
    public static class NumbersExtensions
    {
        public static bool DividesBy(this int div, int divisor) =>
            div % divisor == 0;
    }
}