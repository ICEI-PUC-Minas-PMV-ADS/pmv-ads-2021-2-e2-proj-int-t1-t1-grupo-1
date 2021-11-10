﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Tratamento> Tratamentos { get; set; }

    }
}
