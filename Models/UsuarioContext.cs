using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RifugoApi.Models
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext()
        {

        }

        public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options)
        {

        }

        public DbSet<Usuario> usuarios { get; set; }
    }
}
