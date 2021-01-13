using System;
using BenchmarkDotNet.Running;

namespace FactoryPerf
{
    class Program
    {
        static void Main(string[] args)
        {
            //var b1 = SimpleFactory.GetDefault().Create("A100");
            //var b2 = new GeneratedFactory().Create("A100");
            //var b3 = GeneratedDictionaryFactory.GetDefault().Create("A100");

            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
}
