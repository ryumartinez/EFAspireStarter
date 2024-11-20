using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AT.Access.Common.Domain.Configuration;

internal sealed class PhoneServicesConfiguration : IEntityTypeConfiguration<PhoneServices>
{
    public void Configure(EntityTypeBuilder<PhoneServices> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.DateCreated)
            .HasDefaultValueSql("GetUtcDate()");

        builder
            .Property(x => x.DateUpdated)
            .HasDefaultValueSql("GetUtcDate()");

        builder
            .Property(x => x.Name)
            .HasMaxLength(50);

        builder
            .HasOne(x => x.Phones)
            .WithMany(x => x.Services)
            .HasForeignKey(x => x.PhoneId);

    }
}