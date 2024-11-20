using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AT.Access.Common.Domain.Configuration;

internal sealed class PhoneConfiguration : IEntityTypeConfiguration<Phone>
{
    public void Configure(EntityTypeBuilder<Phone> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.DateCreated)
            .HasDefaultValueSql("GetUtcDate()");

        builder
            .Property(x => x.DateUpdated)
            .HasDefaultValueSql("GetUtcDate()");

        builder
            .Property(x => x.Number)
            .HasMaxLength(50);

        builder
            .Property(x => x.Type)
            .IsRequired();

        builder
            .HasOne(x => x.Person)
            .WithMany(x => x.Phones)
            .HasForeignKey(x => x.PersonId);
        
        builder
            .HasOne(x => x.Country)
            .WithMany(x => x.Phones)
            .HasForeignKey(x => x.CountryId);
    }
}