using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BikeStore.WebUI.AuthIdentity
{
    public class IdentityContext : IdentityDbContext<AppIdentityUser, AppIdentityRole, string>
    {

        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
        {

        }


    }
}
