using mediador.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace mediador.Mapping
{
    public class ProdutoMap  : IEntityTypeConfiguration<Produto>
    {

        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey("Id");
            builder.Property(u =>u.Nome).HasMaxLength(40);
          
        }

    }
}