using System;
using System.Collections.Generic;
using System.Text;
using DotnetSimpleContainer.Interface;

namespace DotnetSimpleContainer.Containers
{
    class Container : IContainer
    {
	    protected ITime Time;

	    public void RegisterTime(ITime time)
	    {
		    Time = time;
	    }

	    public ITime ResolveTime()
	    {
		    return Time;
	    }
    }
}
