
using App.Domain.Abstractions;
using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.Mappings;

public class UserInformationsMapping : EntityBaseMapping, IEntityTypeConfiguration<UserInformations>, IAggregateRoot
{
    public void Configure(EntityTypeBuilder<UserInformations> builder)
    {
        builder.ToTable("UserInformations");

        builder.Property(x => x.Name)
            .HasColumnType("NVARCHAR")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.Cpf)
            .HasColumnType("NVARCHAR")
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(x => x.Rg)
            .HasColumnType("NVARCHAR")
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(x => x.Email)
            .HasColumnType("NVARCHAR")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(x => x.Password)
            .HasColumnType("NVARCHAR(MAX)")
            .IsRequired();

        builder.Property(x => x.PhoneNumber)
            .HasColumnType("NVARCHAR")
            .HasMaxLength(30)
            .IsRequired();

        builder.Property(x => x.UserRole)
            .HasColumnType("TINYINT")
            .IsRequired();
    }
}
