namespace AT.Access.Common.Domain;
public class SocialMediaType : BaseEntity
{
    public string? Name { get; set; }
    public required ICollection<SocialMediaProfile> SocialMediaProfiles { get; set; }
}