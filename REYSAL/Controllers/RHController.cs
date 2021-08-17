using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace REYSAL.Controllers
{
    public class RHController : Controller
    {
        public IActionResult ANII()
        {
            return View();
        }
        
        public IActionResult CEFTRP()
        {
            return View();
        }
        public IActionResult FI()
        {
            return View();
        }
        public IActionResult NF()
        {
            return View();
        }
    }
}