
using App.Domain.Abstractions;
using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructure.Mappings;

public class UserInformationsMapping : IEntityTypeConfiguration<UserInformations>, IAggregateRoot
{
    public void Configure(EntityTypeBuilder<UserInformations> builder)
    {
        builder.ToTable("UserInformations");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.CreationDate)
            .IsRequired(true)
            .HasColumnType("DATETIME2");

        builder.Property(x => x.UpdateDate)
            .IsRequired(false)
            .HasColumnType("DATETIME2");

        builder.Property(x => x.IsActive)
            .IsRequired(true)
            .HasColumnType("BIT");

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
    }
}
