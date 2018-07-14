using System;
using System.Collections.Generic;
using System.Text;
using DryIocUsageSample.Interfaces;

namespace DryIocUsageSample.TextTransform
{
    public class Lowercase : ITextTransform
    {
	    public string Transform(string text)
	    {
		    return text.ToLower();
	    }
    }
}
