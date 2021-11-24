using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MinhaSaude.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinhaSaude.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MinhaSaude.Models.Medicamento> Medicamentos { get; set; }
        public DbSet<MinhaSaude.Models.Tratamento> Tratamentos { get; set; }
    }
}
