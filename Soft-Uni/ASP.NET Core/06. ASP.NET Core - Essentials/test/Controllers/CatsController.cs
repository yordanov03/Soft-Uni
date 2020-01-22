using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using test.Models;
using Microsoft.AspNetCore.Authorization;
using test.Services;

namespace test.Controllers
{
    public class CatsController :Controller
    {
        private readonly ICatService cats;

        public CatsController(ICatService cats)
        {
            this.cats = cats;
        }
       
        public IActionResult Create()
        {
           // var catService = this.HttpContext.RequestServices.GetService(typeof(ICatService));
            return View();

        }
        [Authorize]
        public IActionResult Index()
        {
            //RedirectToAction(nameof(Create), "Home");
           // RedirectToAction(nameof(Create), new {id = 5, name = "Ivan"});
           // var model = new CatDetailsModel {Id = 1, Name = "Pesho"};
            //return View(model);

            ViewData["Name"] = "Ivan";
            return View();
        }

        [HttpPost]
        public IActionResult Index(CatDetailsModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            return View(model);
        }
    }
}
