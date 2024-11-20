using AT.Access.Person.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace AT.Access.Integration.Test;

[TestFixture]
[Category("Integration")]
public partial class PersonTests : TestBase
{
    private PersonDataAccess _sut = null!;

    [SetUp]
    public void SetUp()
    {
        SetupDbContext();
        var personAccessBuilder = new PersonAccessBuilder();
        _sut = new PersonDataAccess(personAccessBuilder, Context);
    }

    [Test]
    public async Task ShouldCreatePersonReturnOk()
    {
        var accessRequest = CreatePersonAccessRequest;

        var actual = await _sut.CreatePersonAsync(accessRequest);
        Assert.Multiple(() =>
        {
            Assert.That(actual.Id, Is.GreaterThanOrEqualTo(1));
            Assert.That(actual.FirstName, Is.EqualTo(accessRequest.FirstName));
            Assert.That(actual.MiddleName, Is.EqualTo(accessRequest.MiddleName));
            Assert.That(actual.LastName, Is.EqualTo(accessRequest.LastName));
            Assert.That(actual.SecondLastName, Is.EqualTo(accessRequest.SecondLastName));
            Assert.That(actual.DateOfBirth, Is.EqualTo(accessRequest.DateOfBirth));
        });
    }
}
