using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AT.Access.Common.Domain.Configuration;


internal sealed class SocialMediaTypeConfiguration : IEntityTypeConfiguration<SocialMediaType>
{
    public void Configure(EntityTypeBuilder<SocialMediaType> builder)
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
            .HasMany(x => x.SocialMediaProfiles)
            .WithOne(x => x.Type)
            .HasForeignKey(x => x.SocialMediaTypeId)
            .OnDelete(DeleteBehavior.Restrict);

    }
}