using AT.Common.Enums;

namespace AT.Access.Common.Domain;
public class PersonLanguages : BaseEntity
{
    public int PersonId { get; set; }
    public LanguageType Language { get; set; }
    public LanguageLevel LanguageLevel { get; set; }
    public required Person Person { get; set; }
}