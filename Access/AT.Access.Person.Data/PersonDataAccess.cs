using AT.Access.Common;
using AT.Access.Person.Data.Contract.Person;
using AT.Access.Person.Data.Contract;
using System.Diagnostics.CodeAnalysis;

namespace AT.Access.Person.Data;

[ExcludeFromCodeCoverage]
public class PersonDataAccess : IPersonDataAccess
{
    private readonly IPersonAccessBuilder _personAccessBuilder;
    private readonly ATDbContext _dbContext;

    public PersonDataAccess(IPersonAccessBuilder personAccessBuilder, ATDbContext dbContext)
    {
        _personAccessBuilder = personAccessBuilder;
        _dbContext = dbContext;
    }

    public async Task<PersonAccessModel> CreatePersonAsync(CreatePersonAccessRequest accessRequest)
    {
        var person = new Common.Domain.Person
        {
            FirstName = accessRequest.FirstName,
            MiddleName = accessRequest.MiddleName,
            LastName = accessRequest.LastName,
            SecondLastName = accessRequest.SecondLastName,
            IsActive = true,
            DateOfBirth = accessRequest.DateOfBirth,
            DateCreated = DateTime.Today,
            UserCreated = "User"
        };
        _dbContext.Person.Add(person);
        await _dbContext.SaveChangesAsync();
        var personAccessModel = _personAccessBuilder.MapEntityToModel(person);

        return personAccessModel;
    }
}