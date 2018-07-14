using System;
using DotnetSimpleContainer.Containers;
using DotnetSimpleContainer.Interface;
using DotnetSimpleContainer.TimeClasses;

namespace DotnetSimpleContainer
{
    class Program
    {
        static void Main(string[] args)
        {
	        IContainer container = new Container();
			container.RegisterTime(new MiamiTime());

	        ITime time = container.ResolveTime();
			Console.WriteLine(time.CurrentTime);

			//-----------------------------------------------------

	        INextContainer nextcontainer = new NextContainer();
	        nextcontainer.Register(typeof(MiamiTime));

	        ITime time1 = nextcontainer.Resolve();
	        ITime time2 = nextcontainer.Resolve();

	        bool isEqual = time1 == time2;

			Console.WriteLine(isEqual);

	        Console.ReadLine();
        }
    }
}
