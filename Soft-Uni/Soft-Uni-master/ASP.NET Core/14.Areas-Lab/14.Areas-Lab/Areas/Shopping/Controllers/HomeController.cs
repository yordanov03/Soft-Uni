using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _14.Areas_Lab.Areas.Shopping.Controllers
{
    [Area("Shopping")]
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
