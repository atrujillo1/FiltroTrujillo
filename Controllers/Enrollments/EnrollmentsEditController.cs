using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FiltroTrujillo.Controllers.Enrollments
{
    [Route("[controller]")]
    public class EnrollmentsEditController : Controller
    {
        private readonly ILogger<EnrollmentsEditController> _logger;

        public EnrollmentsEditController(ILogger<EnrollmentsEditController> logger)
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