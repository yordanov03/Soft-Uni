using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _10._Razor_engine___lab.Data;
using Microsoft.AspNetCore.Mvc;

namespace 10.Razorengine-lab.Component
{
    public class MenuComponent:ViewComponent
{
    private readonly ApplicationDbContext DBContext;

    public MenuComponent(ApplicationDbContext db)
    {
        this.DBContext = db;
    }
    public IViewComponentResult InvokeSomething(int id)
    {
        return this.View();
    }
}
}
