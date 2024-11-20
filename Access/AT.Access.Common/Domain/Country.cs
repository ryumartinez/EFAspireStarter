namespace AT.Access.Common.Domain;
public class Country : BaseEntity
{
    public required string Name { get; set; }
    public string Code { get; set; }
    public string PhoneCode { get; set; }

    public ICollection<State> States { get; set; }
    public ICollection<Phone> Phones { get; set; }
}