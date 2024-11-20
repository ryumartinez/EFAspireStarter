namespace AT.Access.Person.Data.Contract.Person;
public interface IPersonAccessBuilder
{
    PersonAccessModel MapEntityToModel(Common.Domain.Person entity);
    Common.Domain.Person MapCreatePersonAccessRequestToPerson(CreatePersonAccessRequest accessRequest);
}