using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace _12._Razor_and_filters___lab_and_exercise.Infrastructure.Filters
{
    public class HttpsOnlyAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.Request.IsHttps)
            {
                var request = context.HttpContext.Request;
                var url = $"https://{request.Host}/{request.Path}?{request.Query}";
                context.Result = new RedirectResult(url);
            }
        }
    }
}
