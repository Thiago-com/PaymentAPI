using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentAPI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Repository.Mapping
{
    public class VendaMapping : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
           
            builder.Property(v => v.DataVenda).HasDefaultValueSql("now()");
            builder.Property(v=>v.StatusVenda).HasDefaultValue((StatusVenda)0);
       
        }
    }
}
