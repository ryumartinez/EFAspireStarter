namespace AT.Access.Common.Domain;
public class City : BaseEntity
{
    public int StateId { get; set; }
    public required string Name { get; set; }
    public State State { get; set; }
}