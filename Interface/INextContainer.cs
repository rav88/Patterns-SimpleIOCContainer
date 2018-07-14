using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetSimpleContainer.Interface
{
	public interface INextContainer
	{
		void Register(Type type);
		ITime Resolve();
	}
}
