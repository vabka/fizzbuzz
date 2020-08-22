using System;

namespace FizzBuzz.ObjectOrientedFizzBuzz.EnterpriseEdition
{
    public class OloloStringConsoleWriter : IWriter<string>
    {
        public void Write(string obj)
        {
            Console.WriteLine("OLOLO!: " + obj);
        }
    }
}