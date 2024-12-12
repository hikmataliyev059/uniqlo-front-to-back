using Microsoft.AspNetCore.Identity;

namespace UniqloFrontToBack.Models;

public class AppUser : IdentityUser
{
    public string Name { get; set; }
}