using System;
using System.Collections.Generic;
using System.Text;
using DotnetSimpleContainer.Interface;

namespace DotnetSimpleContainer.TimeClasses
{
    public class KantonTime : ITime
    {
	    public string CurrentTime => DateTime.Now.AddHours(6).ToString("yyyy-MM-dd HH:mm:ss.fff");
    }
}
