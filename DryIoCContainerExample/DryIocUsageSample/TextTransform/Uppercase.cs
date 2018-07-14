using System;
using System.Collections.Generic;
using System.Text;
using DryIocUsageSample.Interfaces;

namespace DryIocUsageSample.TextTransform
{
    public class Uppercase : ITextTransform
    {
	    public string Transform(string text)
	    {
		    return text.ToUpper();
	    }
    }
}
