using NetStandard2.NuGet.PoC;
using System;

namespace NetFramework472.NugetConsumer.PoC.Main
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var testClass1 = new TestClass1();
            Console.WriteLine($"Is it a NuGet? {testClass1.IsNuGet}");
        }
    }
}
