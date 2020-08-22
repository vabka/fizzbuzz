using System;
using System.Text;

namespace FizzBuzz.FunctionalFizzBuzz
{
    public static class FizzBuzz
    {
        public static Func<int, string> Combine(params Func<int, string>[] matchers)
        {
            if (matchers.Length == 0)
                throw new ArgumentException(nameof(matchers));
            return number =>
            {
                var sb = new StringBuilder();
                foreach (var matcher in matchers)
                    sb.Append(matcher(number));
                return sb.Length == 0
                    ? number.ToString()
                    : sb.ToString();
            };
        }
    }
}