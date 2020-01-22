using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fluffy_Duffy_Munchkin_Cats.Data;
using Fluffy_Duffy_Munchkin_Cats.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Fluffy_Duffy_Munchkin_Cats
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CatsDBContext>(options =>
                options.UseSqlServer(@"Server=POC0U1OG2E\SQLEXPRESS;Database=CatsServerDb;Integrated Security = true "));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.Use((context, next) =>
            {
                context.RequestServices.GetRequiredService<CatsDBContext>().Database.Migrate();
                return next();
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }

            app.UseStaticFiles();
            app.Use((context, next) =>
            {
                context.Response.Headers.Add("Content-Type", "text/html");
                return next();
            });

            app.MapWhen(ctx => ctx.Request.Path.Value == "/" && ctx.Request.Method == HttpMethod.Get,
                home =>
            {
                home.Run(async (context) =>
                {
                    await context.Response.WriteAsync($"<h1>{env.ApplicationName}</h1>");
                    var db = context.RequestServices.GetService<CatsDBContext>();
                    var catsData = db.cats.Select(c => new { c.Id, c.Name }).ToList();
                    await context.Response.WriteAsync("<ul>");

                    foreach (var cat in catsData)
                    {
                        await context.Response.WriteAsync($@"<li><a href=""/cat{cat.Id}"">{cat.Name}</a></li>");
                    }

                    await context.Response.WriteAsync("<ul>");
                    await context.Response.WriteAsync(@"
                        <form action=""/cat/add"">
                            <input type = ""submit"" value=""Add Cat""/>
                        </form>");
                });
            });

            app.MapWhen(ctx => ctx.Request.Path.Value == "/cat/add" && ctx.Request.Method == HttpMethod.Get, catAdd =>
            {
                catAdd.Run(async context =>
                {
                    if (context.Request.Method == HttpMethod.Get)
                    {
                        context.Response.Redirect("/AddCatForm.html");
                    }
                    else if (context.Request.Method == HttpMethod.Post)
                    {
                        var db = context.RequestServices.GetRequiredService<CatsDBContext>();
                        var formData = context.Request.Form;
                        var age = 0;
                        int.TryParse(formData["Age"], out age);
                        var cat = new Cat { Name = formData["Name"], Age = age, Breed = formData["Breed"], ImageUrl = formData["ImageUrl"] };
                        db.Add(cat);

                        try
                        {
                            await db.SaveChangesAsync();
                            context.Response.Redirect("/");
                        }
                        catch (Exception)
                        {
                            await context.Response.WriteAsync("<h2>Invalid cat data</h2>");
                            await context.Response.WriteAsync(@"<a href==""/cat/add"">Back to the Form!</a>");
                        }
                    }
                });
            });
            app.MapWhen(ctx => ctx.Request.Path.Value.StartsWith("/cat") && ctx.Request.Method == HttpMethod.Get, catDetails => 
            {
                catDetails.Run(async (context) =>
                {
                    var urlParts = context.Request.Path.Value.Split('/', StringSplitOptions.RemoveEmptyEntries);

                    if (urlParts.Length<2)
                    {
                        context.Response.Redirect("/");
                        return;
                    }
                    else
                    {
                        var catId = 0;
                        int.TryParse(urlParts[1], out catId);

                        if (catId==0)
                        {
                            context.Response.Redirect("/");
                            return;
                        }
                        var db = context.RequestServices.GetService<CatsDBContext>();
                        var cat =await db.cats.FindAsync(catId);

                        if (cat==null)
                        {
                            context.Response.Redirect("/");
                            return;
                        }
                        await context.Response.WriteAsync($"<h1>{cat.Name}</h1>");
                        await context.Response.WriteAsync($@"<img src=""{cat.ImageUrl}"" alt=""{cat.Name}"" width=300");
                        await context.Response.WriteAsync($"<p>Age: {cat.Age}</p>");
                        await context.Response.WriteAsync($"<p>Breed: {cat.Breed}</p>");

                    }
                    
                });
            });

            
            app.Run(async (context) =>
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsync("404 Page was not found :/");
            });
        }
    }
}
