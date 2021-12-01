using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MinhaSaude.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinhaSaude.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CaixinhaDeRemedios> CaixinhaDeRemedioss { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Tratamento> Tratamentos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Farmacia> Farmacias { get; set; }
        public DbSet<Administrador> Administradores { get; set; }

    }
}
