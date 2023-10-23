using Orleans.Configuration;
using Orleans.Workshop.Exercise4.Silo;
using System.Net;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.UseOrleans((siloBuilder) =>
{
    siloBuilder.UseLocalhostClustering(11111, 30001, primarySiloEndpoint: new IPEndPoint(IPAddress.Loopback, 11111), serviceId: "orleans-exercise4", clusterId: "orleans-exercise4");

    siloBuilder.Configure<ClusterOptions>(options =>
    {
        options.ClusterId = "orleans-exercise4";
        options.ServiceId = "orleans-exercise4";
    });

    siloBuilder.ConfigureLogging(loggingBuilder =>
    {
        loggingBuilder.AddConsole();
    });

    siloBuilder.UseDashboard();
});

var host = builder.Build();
host.Run();