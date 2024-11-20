using AT.Common.Enums;

namespace AT.Access.Common.Domain;
public class PhoneType : BaseEntity
{
    public required ContactType Type { get; set; }
    public required ICollection<Phone> Phones { get; set; }
}