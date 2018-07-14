using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcIoC.Services
{
	public class LogInfo
	{
		public int GetInfo()
		{
			var path = "Logs.csv";
			int lineCount = 0;

			using (var reader = File.OpenText(path))
			{
				while (reader.ReadLine() != null)
				{
					lineCount++;
				}
			}

			return lineCount;
		}
	}
}
