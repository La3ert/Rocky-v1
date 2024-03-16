using Microsoft.AspNetCore.Identity;

namespace Rocky.Models;

public class ApplicationUsers : IdentityUser
{
    public string FullName { get; set; }
}