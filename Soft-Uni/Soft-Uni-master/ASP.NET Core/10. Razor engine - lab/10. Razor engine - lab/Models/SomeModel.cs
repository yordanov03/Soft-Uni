using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace 10.Razorengine-lab.Models
{
    public class SomeModel
{
    [BindNever]
    public int Id { get; set; }
    [FromQuery]
    public int Number { get; set; }
    [BindRequired]
    [DisplayFormat(ConvertEmptyStringToNull = true/ "Please enter value")]
    public string Text { get; set; }
}
}
