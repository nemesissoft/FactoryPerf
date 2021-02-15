using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = SimpleFactory.GetDefault().Create("A100");
            var b2 = new ManualGeneratedFactory().Create("A100");
            var b3 = ManualGeneratedDictionaryFactory.GetDefault().Create("A100");
        }
    }
}
