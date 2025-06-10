using App.Domain.Abstractions;
using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.Mappings;

public class UserAddressMapping : EntityBaseMapping, IEntityTypeConfiguration<UserAddress>, IAggregateRoot
{
    public void Configure(EntityTypeBuilder<UserAddress> builder)
    {
        builder.ToTable("UserAddress");

        builder.Property(x => x.Cep)
               .HasColumnType("NVARCHAR")
               .HasMaxLength(30)
               .IsRequired();

        builder.Property(x => x.Street)
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80)
            .IsRequired();

        builder.Property(x => x.Neighborhood)
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80)
            .IsRequired();

        builder.Property(x => x.City)
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80)
            .IsRequired();

        builder.Property(x => x.Number)
           .HasColumnType("INT")
           .IsRequired();
    }
}
