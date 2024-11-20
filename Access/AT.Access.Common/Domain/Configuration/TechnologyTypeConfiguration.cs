using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AT.Access.Common.Domain.Configuration;


internal sealed class TechnologyTypeConfiguration : IEntityTypeConfiguration<TechnologyType>
{
    public void Configure(EntityTypeBuilder<TechnologyType> builder)
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
            .HasMaxLength(50)
            .IsRequired();

        builder
            .HasMany(x => x.PersonTechnologies)
            .WithOne(x => x.Technology)
            .HasForeignKey(x => x.TechnologyTypeId)
            .OnDelete(DeleteBehavior.Restrict);

    }
}