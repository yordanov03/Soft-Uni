using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _14.Areas_Lab.Areas.Products.Controllers
{
    [Area("Products")]
    public class CategoriesController : Controller
    {
        public IActionResult Create() => View(); 
    }
}
