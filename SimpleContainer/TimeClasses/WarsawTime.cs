using System;
using System.Collections.Generic;
using System.Text;
using DotnetSimpleContainer.Interface;

namespace DotnetSimpleContainer.TimeClasses
{
    public class WarsawTime : ITime
    {
	    public string CurrentTime => DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
    }
}
