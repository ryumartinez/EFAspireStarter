using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AT.Access.Common.Domain.Configuration;

internal sealed class PersonLangugesConfiguration : IEntityTypeConfiguration<PersonLanguages>
{
    public void Configure(EntityTypeBuilder<PersonLanguages> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.DateCreated)
            .HasDefaultValueSql("GetUtcDate()");

        builder
            .Property(x => x.DateUpdated)
            .HasDefaultValueSql("GetUtcDate()");

        builder.Property(x => x.Language)
                .HasConversion<int>()
                .IsRequired();

        builder
            .HasOne(x => x.Person)
            .WithMany(x => x.PersonLanguages)
            .HasForeignKey(x => x.PersonId);

        builder
            .Property(x => x.LanguageLevel)
            .IsRequired();
    }
}