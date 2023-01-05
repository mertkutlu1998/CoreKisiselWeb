using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKisiselWeb.Controllers
{
    public class DefaultControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
