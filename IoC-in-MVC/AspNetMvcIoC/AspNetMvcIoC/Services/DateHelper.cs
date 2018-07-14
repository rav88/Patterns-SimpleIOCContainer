using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using AspNetMvcIoC.Interfaces;

namespace AspNetMvcIoC.Services
{
	public class DateHelper : IDateHelper
	{
		protected DateTime Date;

		public DateHelper()
		{
			Date = DateTime.Now;
		}

		#region Implementation of IHtmlContent

		public void WriteTo(TextWriter writer, HtmlEncoder encoder)
		{
			writer.Write($"<p>{Date.ToString("yyyy-MM-dd HH:mm:ss.fff")}</p>", encoder);
		}

		#endregion
	}
}
