using System;
using DryIocUsageSample.Interfaces;

namespace DryIocUsageSample.TextTransform
{
    public class Reverse : ITextTransform
    {
	    public string Transform(string text)
	    {
			char[] charArray = text.ToCharArray();
		    Array.Reverse(charArray);
		    return new string(charArray);
		}
    }
}
