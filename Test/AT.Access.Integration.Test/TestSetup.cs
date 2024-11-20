
namespace AT.Access.Integration.Test;

[SetUpFixture]
public class TestSetup
{
    [OneTimeSetUp]
    public async Task OneTimeSetUp()
    {
        var dbContextFactory = new ApplicationDbContextFactory();
        using var dbContext = dbContextFactory.CreateDbContext(Array.Empty<string>());
        await dbContext.Database.EnsureDeletedAsync();
        await dbContext.Database.EnsureCreatedAsync();
    }
}