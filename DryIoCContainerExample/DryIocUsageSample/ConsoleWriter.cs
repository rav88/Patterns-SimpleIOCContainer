using System;
using System.Collections.Generic;
using System.Text;
using DryIocUsageSample.Interfaces;

namespace DryIocUsageSample
{
    public class ConsoleWriter
    {
	    private readonly ITextTransform _textTransform;

	    public ConsoleWriter(ITextTransform textTransform)
	    {
		    _textTransform = textTransform;
	    }

	    public void Write(string message)
	    {
		    string formattedMessage = _textTransform.Transform(message);

		    Console.WriteLine(formattedMessage);
	    }
    }
}
