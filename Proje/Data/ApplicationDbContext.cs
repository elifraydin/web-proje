using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Proje.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

    
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Yemek> Yemek { get; set; }
        public DbSet<YemekMalzeme> MalzemeYemek { get; set; }

        public DbSet<Malzeme> Malzeme { get; set; }

    }
}

