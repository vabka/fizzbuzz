using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public static class EnumerableExtensions
    {
        public static void Iter<T>(this IEnumerable<T> seq, Action<T> action)
        {
            foreach (var e in seq) action(e);
        }
    }
}