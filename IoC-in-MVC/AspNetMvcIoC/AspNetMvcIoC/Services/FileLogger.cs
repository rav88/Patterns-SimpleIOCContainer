using System;
using System.IO;
using AspNetMvcIoC.Interfaces;

namespace AspNetMvcIoC.Services
{
    public class FileLogger : ILogger
    {
	    public ILogger Log(string message)
	    {
		    string path = "Logs.csv";
		    string formattedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

		    var output = $"{formattedDate} {message}";
			File.AppendAllLines(path, new [] { output });

		    return this;
	    }
    }
}
