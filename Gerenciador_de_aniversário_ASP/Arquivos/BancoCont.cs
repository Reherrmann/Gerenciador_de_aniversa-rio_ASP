using System;
using Gerenciador_de_aniversário_ASP.Models;
using Microsoft.EntityFrameworkCore;

namespace Gerenciador_de_aniversário_ASP.Arquivos
{
    public class BancoCont : DbContext
    {
        public BancoCont(DbContextOptions<BancoCont>options) : base(options) { }

        public DbSet<CadastroModel> Pessoas { get; set; }
    }
}

