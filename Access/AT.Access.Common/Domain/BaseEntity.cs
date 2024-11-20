namespace AT.Access.Common.Domain;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }
    public string UserCreated { get; set; }
    public string? UserUpdated { get; set; }
}