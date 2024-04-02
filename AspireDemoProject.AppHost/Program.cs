var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireDemoProject_ApiService>("apiservice");

builder.AddProject<Projects.AspireDemoProject_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();
