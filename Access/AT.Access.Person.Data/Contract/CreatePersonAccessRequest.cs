namespace AT.Access.Person.Data.Contract;
public record CreatePersonAccessRequest(

    string FirstName,
    string? MiddleName,
    string LastName,
    string? SecondLastName,
    DateTime DateOfBirth
);