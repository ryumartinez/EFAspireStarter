using AT.Common.Enums;

namespace AT.Access.Common.Domain;
public class Phone : BaseEntity
{
    public int CountryId { get; set; }
    public int PersonId { get; set; }
    public required string Number { get; set; }
    public int PhoneTypeId { get; set; }
    public int PhoneServiceId { get; set; }
    public required ContactType Type { get; set; }
    public required ICollection<PhoneServices> Services { get; set; }
    public required virtual Person Person { get; set; }
    public required virtual Country Country { get; set; }
}