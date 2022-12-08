using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CadastroAPI.Data
{
    public class CadastroContext : DbContext
    {
        public CadastroContext(DbContextOptions<CadastroContext> opt) : base(opt)
        { }

        public DbSet<Cadastro> Registros { get; set; }
    }
}
