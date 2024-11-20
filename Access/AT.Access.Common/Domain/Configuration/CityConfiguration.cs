using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AT.Access.Common.Domain.Configuration;

internal sealed class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.DateCreated)
            .HasDefaultValueSql("GetUtcDate()");

        builder
            .Property(x => x.DateUpdated)
            .HasDefaultValueSql("GetUtcDate()");

        builder
            .Property(x => x.Name!)
            .HasMaxLength(50);
        
        builder
            .HasOne(x => x.State)
            .WithMany(x => x.Cities)
            .HasForeignKey(x => x.StateId);
    }
}