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
    public class TeachersEditController : Controller
    {
        private readonly ILogger<TeachersEditController> _logger;

        public TeachersEditController(ILogger<TeachersEditController> logger)
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