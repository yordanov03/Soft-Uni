using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _14.Areas_Lab.Models;
using _14.Areas_Lab.Data;
using AutoMapper.QueryableExtensions;
using AutoMapper;

namespace _14.Areas_Lab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public HomeController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var user = new ApplicationUser
            {
                Id = "1",
                Email = "ivan@ivan.com",
                UserName = "Ivan"
            };

            var mappedUser = this.mapper.Map<UserViewModel>(user);
            var users = this.db.Users.ProjectTo<UserViewModel>().ToList();

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

