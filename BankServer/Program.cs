using Microsoft.Extensions.Hosting;

Console.WriteLine("Silo.");
await Host.CreateDefaultBuilder(args)
    .UseOrleans(siloBuilder =>
    {
        siloBuilder
            .UseLocalhostClustering()
            .AddMemoryGrainStorageAsDefault()
            .UseTransactions();
    })
    .RunConsoleAsync();