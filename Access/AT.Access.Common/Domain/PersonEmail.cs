using AT.Common.Enums;

namespace AT.Access.Common.Domain;
public class PersonEmail : BaseEntity
{
    public int PersonId { get; set; }
    public required string EmailAddress { get; set; }
    public required ContactType Type { get; set; }

    public required virtual Person Person { get; set; }
}