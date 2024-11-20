using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AT.Access.Common.Domain.Configuration;

internal sealed class PersonEmailConfiguration : IEntityTypeConfiguration<PersonEmail>
{
    public void Configure(EntityTypeBuilder<PersonEmail> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.DateCreated)
            .HasDefaultValueSql("GetUtcDate()");

        builder
            .Property(x => x.DateUpdated)
            .HasDefaultValueSql("GetUtcDate()");

        builder
            .Property(x => x.EmailAddress!)
            .HasMaxLength(50);

        builder
            .Property(x => x.Type)
            .IsRequired();

        builder
            .HasOne(x => x.Person)
            .WithMany(x => x.Emails)
            .HasForeignKey(x => x.PersonId);

    }
}