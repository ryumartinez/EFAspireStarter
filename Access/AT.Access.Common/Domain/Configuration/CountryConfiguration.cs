using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AT.Access.Common.Domain.Configuration;

internal sealed class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.DateCreated)
            .HasDefaultValueSql("GetUtcDate()");

        builder
            .Property(x => x.DateUpdated)
            .HasDefaultValueSql("GetUtcDate()");

        builder
            .Property(x => x.Code)
            .HasMaxLength(2);

        builder
            .Property(x => x.Name)
            .HasMaxLength(50);

        builder
            .Property(x => x.PhoneCode)
            .HasMaxLength(5);
    }
}