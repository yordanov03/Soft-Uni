using BookShop.Services.Interfaces;
using BookShop.Services.Models;
using BookShop.Web.Infrastructure.Filters;
using BookShop.Web.Interfaces;
using BookShop.Web.Models.Authors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Web.Controllers
{
    public class AuthorsController:BaseApiController
    {
        private readonly IAuthorService authorService;

        public AuthorsController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(string id)
        {
            return this.OkOrNotFound(this.authorService.GetAuthor(id));

        }

        [HttpPost]
        [ValidateModelState]
        public IActionResult Post ([FromBody] AuthorRequestModel model)
        {
            var author = this.authorService.CreateAuthor(model.FirstName, model.LastName);
            return Ok(author);
        }
    }
}
