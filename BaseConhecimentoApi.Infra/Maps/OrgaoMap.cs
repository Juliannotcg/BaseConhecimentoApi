using BaseConhecimentoApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BaseConhecimentoApi.Infra.Maps
{
    public class OrgaoMap : IEntityTypeConfiguration<Orgao> 
    {
        public void Configure(EntityTypeBuilder<Orgao> builder)
        {
            builder.ToTable("Orgao");

            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("VARCHAR(20)");


            builder.Property(c => c.Descricao)
                .IsRequired()
                .HasColumnType("VARCHAR(200)");
        }
    }
}