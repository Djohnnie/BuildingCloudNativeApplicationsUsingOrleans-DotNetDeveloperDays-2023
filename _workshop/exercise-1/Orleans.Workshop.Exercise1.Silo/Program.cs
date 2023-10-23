using Orleans.Configuration;
using System.Net;

var builder = Host.CreateApplicationBuilder(args);

builder.UseOrleans((siloBuilder) =>
{
    siloBuilder.UseLocalhostClustering(11111, 30001, primarySiloEndpoint: new IPEndPoint(IPAddress.Loopback, 11111), serviceId: "orleans-exercise1", clusterId: "orleans-exercise1");

    siloBuilder.Configure<ClusterOptions>(options =>
    {
        options.ClusterId = "orleans-exercise1";
        options.ServiceId = "orleans-exercise1";
    });

    siloBuilder.ConfigureLogging(loggingBuilder =>
    {
        loggingBuilder.AddConsole();
    });

    siloBuilder.UseDashboard();
});

var host = builder.Build();
host.Run();