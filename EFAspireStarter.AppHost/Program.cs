var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.EFAspireStarter_ApiService>("apiservice");

builder.AddProject<Projects.EFAspireStarter_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
