// See https://aka.ms/new-console-template for more information

using Net6.NuGet.PoC.Services;
using Net6.NuGet.PoC.Services.Interfaces;
using System.Text;

const string helloWorld = "Hello, World!";

Console.WriteLine(helloWorld);

ITestService testService = new TestServiceImplementation();

Console.WriteLine(testService.Base64Encode(Encoding.UTF8.GetBytes(helloWorld)));

