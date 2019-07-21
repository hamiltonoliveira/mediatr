using mediador.Mapping;
using mediador.Models;
using Microsoft.EntityFrameworkCore;

namespace mediador.Contexto
{

    public class ContextoDB: DbContext
    {

        public ContextoDB(DbContextOptions<ContextoDB> options)
          : base(options)
        { }
      

          public DbSet<Produto> Produtos {get;set;}
          protected override  void OnModelCreating(ModelBuilder modelBuilder)
          {
            //usando a classe de mapeamento
            modelBuilder.ApplyConfiguration(new ProdutoMap());
           //usando a classe de mapeamento
          }
    }
}