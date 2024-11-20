namespace AT.Access.Person.Data.Contract.Person;
public interface IPersonDataAccess
{
    Task<PersonAccessModel> CreatePersonAsync(CreatePersonAccessRequest accessRequest);
}