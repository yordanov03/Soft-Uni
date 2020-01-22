using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using _13.Identity_lab.Data;
using _13.Identity_lab.Infrastructure;
using _13.Identity_lab.Models;
using _13.Identity_lab.Models.Identity;

namespace _13.Identity_lab.Controllers
{
    [Authorize(Roles = GlobalConstants.AdministratorRole)]
    public class IdentityController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public IdentityController(ApplicationDbContext db, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.db = db;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        public IActionResult All()
        {
            var users = this.db.Users.Select(u => new ListUserModel { Id = u.Id, Username = u.UserName, Email = u.Email }).ToList();
            return View(users);
        }

        public async Task<IActionResult> Roles(string id)
        {
            var user = await this.userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }
            var roles = await this.userManager.GetRolesAsync(user);
            return View(new UserWithRolesVIewModel { Id = user.Id, Email = user.Email, Roles = roles });
        }

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

           var result = await this.userManager.CreateAsync(new ApplicationUser
            {
                Email = model.Email,
                UserName = model.Email
            }, model.Password);

           if (result.Succeeded)
           {
               this.TempData["SuccessMessage"] = $"USer with {model.Email} has been created!";
               return RedirectToAction(nameof(All));
           }

           else
           {
               foreach (var error in result.Errors)
               {
                   ModelState.AddModelError(string.Empty, error.Description);
               }

               return View(model);
           }

        }

        public async Task< IActionResult> IdentityChangePassword(string id)
        {
            var user = await this.userManager.FindByIdAsync(id);

            return View(new IdentityChangePassword
            {
                Email = user.Email
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> IdentityChangePassword(string id, IdentityChangePassword model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            var user = await userManager.FindByIdAsync(id);
            var token = await userManager.GeneratePasswordResetTokenAsync(user);
            var result = await this.userManager.ResetPasswordAsync(user, token, model.Password);

            if (result.Succeeded)
            {
                this.TempData["SuccessMessage"] = $"Password changed for {user.Email}!";
                return RedirectToAction(nameof(All));
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                return View(model);
            }
        }

        public async Task< IActionResult> Delete(string id)
        {
            var user = await this.userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return View(new DeleteUserViewModel
            {
                Id = user.Id,
                Email = user.Email

            });
        }
        
        public async Task<IActionResult> Destroy(string id)
        {
            var user = await this.userManager.FindByIdAsync(id);

            if(user==null)
            {
                NotFound();
            }
            await this.userManager.DeleteAsync(user);
            TempData["SuccessMessage"] = $"User {user.Email} has been deleted!";
            return RedirectToAction(nameof(All));
        }

        public IActionResult AddToRole(string id)
        {
            var rolesSelectListItems = this.roleManager.Roles.Select(r => new SelectListItem {Text = r.Name, Value = r.Name}).ToList();
            return View(rolesSelectListItems); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddToRole(string id, string role)
        {
            var user = await this.userManager.FindByIdAsync(id);
            var roleExists = await this.roleManager.RoleExistsAsync(role);

            if (user==null || roleExists)
            {
                return NotFound();
            }

            await this.userManager.AddToRoleAsync(user, role);
            TempData["SuccessMessage"] = $"User {user.Email} added to {role} role!";
            return RedirectToAction(nameof(All));
        }
    }
}
