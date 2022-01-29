using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Grosu_George.Models;

namespace GrosuGeorgeDBCrudFarmacie.Models
{
    public class GrosuGeorgeDBCrudFarmacieContext : DbContext
    {
        public GrosuGeorgeDBCrudFarmacieContext (DbContextOptions<GrosuGeorgeDBCrudFarmacieContext> options)
            : base(options)
        {
        }

        public DbSet<Grosu_George.Models.Farmacii> Farmacii { get; set; }

        public DbSet<Grosu_George.Models.Oras> Oras { get; set; }

        public DbSet<Grosu_George.Models.Produse> Produse { get; set; }
    }
}
