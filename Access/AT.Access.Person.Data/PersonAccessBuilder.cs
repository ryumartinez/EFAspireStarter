using AT.Access.Person.Data.Contract;
using AT.Access.Person.Data.Contract.Person;
using System.Runtime.ExceptionServices;

namespace AT.Access.Person.Data;

public class PersonAccessBuilder : IPersonAccessBuilder
{
    public Common.Domain.Person MapCreatePersonAccessRequestToPerson(CreatePersonAccessRequest accessRequest) => new()
    {
        FirstName = accessRequest.FirstName,
        MiddleName = accessRequest.MiddleName,
        LastName = accessRequest.LastName,
        SecondLastName = accessRequest.SecondLastName,
        DateOfBirth = accessRequest.DateOfBirth,
    };
    public PersonAccessModel MapEntityToModel(Common.Domain.Person entity)
    {
        return new PersonAccessModel(
            entity.Id,
            entity.FirstName,
            entity.MiddleName,
            entity.LastName,
            entity.SecondLastName,
            entity.IsActive,
            entity.DateOfBirth
        );
    }
}