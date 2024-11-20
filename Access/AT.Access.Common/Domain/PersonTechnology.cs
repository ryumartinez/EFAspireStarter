using AT.Common.Enums;

namespace AT.Access.Common.Domain;
public class PersonTechnology : BaseEntity
{
    public int PersonId { get; set; }
    public int TechnologyTypeId { get; set; }
    public TechnologyLevel Level { get; set; }
    public int YearsOfExperience { get; set; }
    public required virtual Person Person { get; set; }
    public required virtual TechnologyType Technology { get; set; }
}