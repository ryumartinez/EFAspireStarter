namespace AT.Access.Common.Domain;
public class SocialMediaProfile : BaseEntity
{
    public int PersonId { get; set; }
    public int SocialMediaTypeId { get; set; }
    public required string URL { get; set; }
    public required virtual SocialMediaType Type { get; set; }
    public required virtual Person Person { get; set; }
}