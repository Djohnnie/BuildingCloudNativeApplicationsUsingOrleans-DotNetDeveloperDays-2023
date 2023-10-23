using Orleans.Configuration;
using Orleans.Workshop.Exercise3.Silo;
using System.Net;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.UseOrleans((siloBuilder) =>
{
    siloBuilder.UseLocalhostClustering(11111, 30001, primarySiloEndpoint: new IPEndPoint(IPAddress.Loopback, 11111), serviceId: "orleans-exercise3", clusterId: "orleans-exercise3");

    siloBuilder.Configure<ClusterOptions>(options =>
    {
        options.ClusterId = "orleans-exercise3";
        options.ServiceId = "orleans-exercise3";
    });

    siloBuilder.ConfigureLogging(loggingBuilder =>
    {
        loggingBuilder.AddConsole();
    });

    siloBuilder.Configure<GrainCollectionOptions>(o =>
    {
        o.CollectionAge = TimeSpan.FromSeconds(30);
        o.CollectionQuantum = TimeSpan.FromSeconds(10);
    });

    siloBuilder.UseDashboard();
});

var host = builder.Build();
host.Run();