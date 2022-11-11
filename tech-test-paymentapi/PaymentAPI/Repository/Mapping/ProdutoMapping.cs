using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentAPI.Models.Entity;

namespace PaymentAPI.Repository.Mapping
{
    public class ProdutoMapping: IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.Property(b => b.Quantidade).HasDefaultValue(0);
        }
    }
}
