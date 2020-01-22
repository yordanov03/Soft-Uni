using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace _13.Identity_lab.Models.Identity
{
    public class UserWithRolesVIewModel
{
    public string Id { get; set; }
    public string Email { get; set; }
    public IEnumerable<string> Roles { get; set; }
}
}
