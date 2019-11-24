using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Users.Models;

namespace Users
{
    public class AppDataBaseContext: DbContext
    {
        public AppDataBaseContext(DbContextOptions<AppDataBaseContext> options) 
            : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
