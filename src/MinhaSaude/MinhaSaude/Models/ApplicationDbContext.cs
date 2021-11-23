using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaSaude.Models
{
    public class ApplicationDbContext : DbContext
    {
        //configura a injeção de dependência
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }

        public DbSet<CaixinhaDeRemedios> CaixinhaDeRemedioss { get; set; }

    }
}
