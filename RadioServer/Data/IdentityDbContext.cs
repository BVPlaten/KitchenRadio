using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using RadioServer.Models;

namespace RadioServer.Data
{
    public class IdentityDbContext : Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options)
            : base(options)
        {
        }
    }

    public class RadioDbContext : DbContext
    {
        public RadioDbContext(DbContextOptions<RadioDbContext> options)
            : base(options)
        {
        }
        public DbSet<RadioServer.Models.RadioStations> RadioStations { get; set; }
    }
}
