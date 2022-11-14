using API_Csharp.Models;
using System.Collections.Generic;

namespace ApiAgencia_Csharp.Models
{
    public class PassagemDbContext
    {
            public PassagemDbContext(DbContextOptions<PassagemDbContext> options)
              : base(options)
            { }

            public DbSet<Passagem> Passagens { get; set; }

        }
    }
}

