using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AT.Access.Common.Domain.Configuration;

internal sealed class PersonTechnologyConfiguration : IEntityTypeConfiguration<PersonTechnology>
{
    public void Configure(EntityTypeBuilder<PersonTechnology> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.DateCreated)
            .HasDefaultValueSql("GetUtcDate()");

        builder
            .Property(x => x.DateUpdated)
            .HasDefaultValueSql("GetUtcDate()");

        builder
            .Property(x => x.Level)
            .IsRequired();

        builder
            .Property(x => x.YearsOfExperience)
            .HasMaxLength(50);

        builder
            .HasOne(x => x.Person)
            .WithMany(x => x.PersonTechnologies)
            .HasForeignKey(x => x.PersonId);

        builder
            .HasOne(x => x.Technology)
            .WithMany()
            .HasForeignKey(x => x.TechnologyTypeId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}