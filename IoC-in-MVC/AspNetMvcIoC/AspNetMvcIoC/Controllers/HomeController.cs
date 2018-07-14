using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AspNetMvcIoC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AspNetMvcIoC.Models;
using AspNetMvcIoC.Services;
using Microsoft.AspNetCore.Html;

namespace AspNetMvcIoC.Controllers
{
    public class HomeController : Controller
    {
	    protected readonly ILogger Logger;

	    public HomeController(ILogger logger)
	    {
		   Logger = logger;
	    }

	    public IActionResult Index()
	    {
		    Logger.Log("Strona uruchomiona");

	        return View();
        }

	    public IActionResult GetLogInfo([FromServices] LogInfo logInfo)
	    {
		    var count = logInfo.GetInfo();

		    return Content(count.ToString());
	    }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
