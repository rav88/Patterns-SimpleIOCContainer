using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetSimpleContainer.Interface
{
	public interface IContainer
	{
		void RegisterTime(ITime time);
		ITime ResolveTime();

		//void Register<T>(T item);
		//T Resolve<T>();
	}
}
