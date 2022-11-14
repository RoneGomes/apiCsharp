using API_Csharp.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API_Csharp.Models
{
    public class ClienteDbContext : DbContext
    {
        public ClienteDbContext(DbContextOptions<ClienteDbContext> options)
          : base(options)
        { }

        public DbSet<Cliente> Clientes { get; set; }

    }
}
