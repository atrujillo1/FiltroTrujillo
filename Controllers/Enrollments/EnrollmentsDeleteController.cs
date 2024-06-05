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
    public class EnrollmentsDeleteController : Controller
    {
        private readonly ILogger<EnrollmentsDeleteController> _logger;

        public EnrollmentsDeleteController(ILogger<EnrollmentsDeleteController> logger)
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