using AT.Access.Person.Data.Contract;
using AT.Access.Person.Data.Contract.Person;

namespace AT.Access.Integration.Test;

public partial class PersonTests
{
    private static CreatePersonAccessRequest CreatePersonAccessRequest => new(
        "John1",
        "Alex4444nder201",
        "Smith3",
        "Rowe4",
        DateTime.Today
    );
}
