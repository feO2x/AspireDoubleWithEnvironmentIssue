var builder = DistributedApplication.CreateBuilder(args);
builder
   .AddContainer("nginx", "nginx", "1.27.4")
   .WithEnvironment("FOO", "BAR")
   .WithEnvironment("BAZ", "QUX")
   .WithHttpEndpoint(targetPort: 80);
builder.Build().Run();