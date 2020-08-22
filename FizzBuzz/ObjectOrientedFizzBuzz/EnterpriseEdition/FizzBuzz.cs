using System.Collections.Generic;

namespace FizzBuzz.ObjectOrientedFizzBuzz.EnterpriseEdition
{
    public class FizzBuzz<TSeq, TMatch> : AbstractFizzBuzz<TSeq, TMatch>
    {
        private readonly IEnumerable<TSeq> sequence;
        private readonly IMatcher<TSeq, TMatch> matcher;
        private readonly IWriter<TMatch> writer;

        public FizzBuzz(IEnumerable<TSeq> sequence,
            IMatcher<TSeq, TMatch> matcher,
            IWriter<TMatch> writer)
        {
            this.sequence = sequence;
            this.matcher = matcher;
            this.writer = writer;
        }

        protected override void Write(TMatch match) => writer.Write(match);
        protected override TMatch GetMatch(TSeq elem) => matcher.Match(elem);
        protected override IEnumerable<TSeq> GetSequence() => sequence;
    }
}