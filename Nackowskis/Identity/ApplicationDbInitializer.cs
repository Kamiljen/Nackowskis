using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nackowskis.Identity
{
    public static class ApplicationDbInitializer
    {
        public static void SeedUsers(UserManager<AppUser> userManager)
        {
            if (userManager.FindByEmailAsync("alex@test.com").Result == null)
            {
                AppUser user = new AppUser
                {
                    UserName = "alex@test.com",
                    Email = "alex@test.com"
                };

                IdentityResult result = userManager.CreateAsync(user, "!Nackademin002").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }
    }
}
