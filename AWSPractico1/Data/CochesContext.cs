using AWSPractico1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSPractico1.Data
{
    public class CochesContext: DbContext
    {
        public CochesContext(DbContextOptions<CochesContext> options)
            : base(options) { }
        public DbSet<Coche> Coches { get; set; }
    }
}
