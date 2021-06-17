using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebLab6.Models;

namespace WebLab6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Error()
        {
            return this.View();
        }
    }
}
