using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace test.Models
{
    public class CatDetailsModel
    {
        public int Id { get; set; }
        [Required][MaxLength(10, ErrorMessage ="Max length is 10")]
        public string  Name { get; set; }
    }
}
