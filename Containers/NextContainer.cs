using System;
using System.Collections.Generic;
using System.Text;
using DotnetSimpleContainer.Interface;
using DotnetSimpleContainer.TimeClasses;

namespace DotnetSimpleContainer.Containers
{
    public class NextContainer : INextContainer
    {
	    protected Type Type;

	    public void Register(Type type)
	    {
		    Type = type;
	    }

	    public ITime Resolve()
	    {
			return Activator.CreateInstance(Type) as ITime;
		}
    }
}
