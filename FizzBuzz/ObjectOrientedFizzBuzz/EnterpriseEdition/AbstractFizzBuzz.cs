using System.Collections.Generic;
using FizzBuzz.ObjectOrientedFizzBuzz.Abstractions;

namespace FizzBuzz.ObjectOrientedFizzBuzz.EnterpriseEdition
{
    public abstract class AbstractFizzBuzz<TSeq, TMatch> : IFizzBuzz
    {
        public void Execute()
        {
            foreach (var elem in GetSequence())
            {
                var match = GetMatch(elem);
                Write(match);
            }
        }

        protected abstract void Write(TMatch match);

        protected abstract TMatch GetMatch(TSeq elem);

        protected abstract IEnumerable<TSeq> GetSequence();
    }
}