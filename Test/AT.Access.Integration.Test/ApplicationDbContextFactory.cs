using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using AT.Access.Common;

namespace AT.Access.Integration.Test;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ATDbContext>
{
    public ATDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ATDbContext>();
        optionsBuilder.UseSqlServer("Server=(local);Database=Abstra.Db;Integrated Security=True;MultipleActiveResultSets=False;TrustServerCertificate=True");

        return new ATDbContext(optionsBuilder.Options);
    }
}
