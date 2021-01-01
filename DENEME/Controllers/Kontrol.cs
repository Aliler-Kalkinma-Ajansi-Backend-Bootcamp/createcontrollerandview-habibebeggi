using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DENEME.Controllers
{
    public class Kontrol : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Default()
        {
            return View();
        }
    }
}
