namespace AT.Access.Common.Domain;
public class State : BaseEntity
{
    public int CountryId { get; set; }
    public required string Name { get; set; }
    public Country Country { get; set; }
    public ICollection<City> Cities { get; set; }
}