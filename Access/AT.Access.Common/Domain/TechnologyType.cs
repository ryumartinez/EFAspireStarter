using System.Diagnostics.CodeAnalysis;

namespace AT.Access.Common.Domain;

[ExcludeFromCodeCoverage]
public class TechnologyType : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public required virtual ICollection<PersonTechnology> PersonTechnologies { get; set; } 
}