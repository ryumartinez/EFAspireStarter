namespace AT.Access.Person.Data.Contract.Person;
public record PersonAccessModel(
    int Id,
    string FirstName,
    string? MiddleName,
    string LastName,
    string? SecondLastName,
    bool IsActive,
    DateTime DateOfBirth
);