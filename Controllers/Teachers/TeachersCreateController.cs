using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FiltroTrujillo.Controllers.Teachers
{
    [Route("[controller]")]
    public class TeachersCreateController : Controller
    {
        private readonly ILogger<TeachersCreateController> _logger;

        public TeachersCreateController(ILogger<TeachersCreateController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}