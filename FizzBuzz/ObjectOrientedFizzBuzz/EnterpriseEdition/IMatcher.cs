namespace FizzBuzz.ObjectOrientedFizzBuzz.EnterpriseEdition
{
    public interface IMatcher<in TIn, out TOut>
    {
        TOut Match(TIn input);
    }
}