namespace AT.Access.Common.Domain;

public class Person : BaseEntity

{
    public required string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public required string LastName { get; set; }
    public string? SecondLastName { get; set; }
    public bool IsActive { get ; set; }
    public DateTime DateOfBirth { get; set; }
    public ICollection<SocialMediaProfile>? SocialMediaProfiles { get; set; }
    public ICollection<PersonEmail>? Emails { get; set; }
    public ICollection<Address>? Addresses { get; set; }
    public ICollection<PersonDocument>? PersonalDocuments { get; set; }
    public ICollection<PersonTechnology>? PersonTechnologies { get; set; }
    public ICollection<Phone>? Phones { get; set; }
    public ICollection<PersonLanguages>? PersonLanguages { get; set; }

}