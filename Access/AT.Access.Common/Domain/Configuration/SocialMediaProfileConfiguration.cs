using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AT.Access.Common.Domain.Configuration;

internal sealed class SocialMediaProfileConfiguration : IEntityTypeConfiguration<SocialMediaProfile>
{
    public void Configure(EntityTypeBuilder<SocialMediaProfile> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.DateCreated)
            .HasDefaultValueSql("GetUtcDate()");

        builder
            .Property(x => x.DateUpdated)
            .HasDefaultValueSql("GetUtcDate()");

        builder
            .Property(x => x.URL)
            .HasMaxLength(200)
            .IsRequired();

        builder
            .HasOne(x => x.Type)
            .WithMany()
            .HasForeignKey(x => x.SocialMediaTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(x => x.Person)
            .WithMany(x => x.SocialMediaProfiles)
            .HasForeignKey(x => x.PersonId)
            .OnDelete(DeleteBehavior.Restrict);

    }
}