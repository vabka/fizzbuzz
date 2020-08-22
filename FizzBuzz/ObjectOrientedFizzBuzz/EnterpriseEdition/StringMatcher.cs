using System;
using System.Linq;

namespace FizzBuzz.ObjectOrientedFizzBuzz.EnterpriseEdition
{
    public class StringMatcher<TIn> : IMatcher<TIn, string>
    {
        private readonly Func<TIn, string>[] matchers;
        private readonly Func<TIn, string> defaultMatch;

        public StringMatcher(Func<TIn, string> defaultMatch, params Func<TIn, string>[] matchers)
        {
            this.defaultMatch = defaultMatch;
            this.matchers = matchers;
        }

        public string Match(TIn input)
        {
            if (matchers.Length == 0)
                return defaultMatch(input);
            var res = matchers.Select(m => m(input)).Aggregate((a, b) => a + b);
            return res == "" ? defaultMatch(input) : res;
        }
    }
}