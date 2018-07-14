using System;
using DryIoc;
using DryIocUsageSample.Interfaces;
using DryIocUsageSample.TextTransform;

namespace DryIocUsageSample
{
    class Program
    {
        static void Main(string[] args)
        {
	        var container = new Container();
			container.Register<ConsoleWriter>();
			container.Register<ITextTransform, Uppercase>();

	        var cw = container.Resolve<ConsoleWriter>();
			cw.Write("Abc");

	        Console.ReadLine();
        }
    }
}
