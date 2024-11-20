using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AT.Access.Common.Domain.Configuration;

internal sealed class PersonDocumentConfiguration : IEntityTypeConfiguration<PersonDocument>
{
    public void Configure(EntityTypeBuilder<PersonDocument> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.DateCreated)
            .HasDefaultValueSql("GetUtcDate()");

        builder
            .Property(x => x.DateUpdated)
            .HasDefaultValueSql("GetUtcDate()");

        builder
            .Property(x => x.DocumentNumber!)
            .HasMaxLength(50);

        builder.Property(x => x.IdentificationType)
                .HasConversion<int>();
                
        builder
            .HasOne(x => x.Person)
            .WithMany()
            .HasForeignKey(x => x.PersonId);

    }
}