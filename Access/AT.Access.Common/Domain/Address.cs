using AT.Common.Enums;

namespace AT.Access.Common.Domain;
public class Address : BaseEntity 
{
    public int PersonId { get; set; }
    public required string AddressLine {  get; set; }
    public int CityId { get; set; }
    public ContactType Type { get; set; }
    public virtual Person Person { get; set; }
    public virtual City City { get; set; }
}