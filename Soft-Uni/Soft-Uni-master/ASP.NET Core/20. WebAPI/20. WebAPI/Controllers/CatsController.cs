using _20._WebAPI.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20._WebAPI.Controllers
{
   
    public class CatsController:BaseApiController
    {
        private readonly IData data;

        public CatsController(IData data)
        {
            this.data = data;
        }

        [HttpGet]

        public IEnumerable<Cat> Get()
        {
            return this.data.All();
        }
        [HttpGet("{id}")]
        public Cat Get(int id)
        {
            return this.data.Find(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Cat cat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var id = this.data.Add(cat);
            return Ok(id);
        }

        [HttpPut]
        public IActionResult Put (int id, [FromBody] Cat cat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dataCat = this.data.Find(id);

            if (dataCat==null)
            {
                return NotFound();
            }
            dataCat.Name = cat.Name;
            dataCat.Color = cat.Color;
            dataCat.Age = cat.Age;

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Delete(int id)
        {
            var cat = this.data.Find(id);

            if (cat==null)
            {
                return NotFound();
            }

            this.data.Delete(id);

            return Ok();
        }
    }
}
