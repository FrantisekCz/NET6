using Hello_World.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data
{
    class PeopleContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Auto> Cars { get; set; }
        public DbSet<Address> Addresses { get; set; }

        // zkopírováno z dokumentace
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //            => options.UseSqlServer($"Server=(localdb);Database=peopledb;User Id=myUsername;Password=myPassword;")
            options.UseSqlite(@"Data Source=C:\Users\Student\Desktop\2021-11 Školení C#\CNET1\01 HelloWorld\01 Hello World\WpfApp1\people.db");
        }

    }
}
