using AT.Access.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT.Access.Integration.Test;
public abstract class TestBase
{
    public ATDbContext Context { get; set; } = null!;

    public void SetupDbContext()
    {
        var dbContextFactory = new ApplicationDbContextFactory();
        Context = dbContextFactory.CreateDbContext(Array.Empty<string>());
    }

    [TearDown]
    public void TearDown()
    { 
        Context?.Dispose(); 
    }
}
