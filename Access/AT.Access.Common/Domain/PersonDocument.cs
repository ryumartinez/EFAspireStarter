using AT.Common.Enums;

namespace AT.Access.Common.Domain;
public class PersonDocument : BaseEntity
{
    public int PersonId { get; set; }
    public required string DocumentNumber { get; set; }
    public PersonalIdentificationType IdentificationType { get; set; }
    public required virtual Person Person { get; set; }
}