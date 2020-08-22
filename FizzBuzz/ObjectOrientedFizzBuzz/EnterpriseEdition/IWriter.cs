namespace FizzBuzz.ObjectOrientedFizzBuzz.EnterpriseEdition
{
    public interface IWriter<in T>
    {
        void Write(T obj);
    }
}