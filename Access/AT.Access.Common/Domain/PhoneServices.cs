namespace AT.Access.Common.Domain;
public class PhoneServices : BaseEntity
{
    public int PhoneId { get; set; }
    public required string Name {  get; set; }
    public required Phone Phones { get; set; }
}