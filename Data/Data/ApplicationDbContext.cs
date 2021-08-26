using Data.EntityModels;
using LaCasa.EntityModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaCasa.EF
{
    public class ApplicationDbContext : IdentityDbContext<Korisnik>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Restoran> Restorani { get; set; }
        public DbSet<Recenzija> Recenzije { get; set; }
        public DbSet<TipKuhinje> TipKuhinje { get; set; }
        public DbSet<Kategorija> Kategorije { get; set; }
    }
}
