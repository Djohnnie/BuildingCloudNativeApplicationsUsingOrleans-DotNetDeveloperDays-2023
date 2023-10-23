using Orleans.Configuration;
using System.Net;

var builder = Host.CreateApplicationBuilder(args);

builder.UseOrleans((siloBuilder) =>
{
    siloBuilder.UseLocalhostClustering(11111, 30001, primarySiloEndpoint: new IPEndPoint(IPAddress.Loopback, 11111), serviceId: "orleans-exercise5", clusterId: "orleans-exercise5");

    siloBuilder.Configure<ClusterOptions>(options =>
    {
        options.ClusterId = "orleans-exercise5";
        options.ServiceId = "orleans-exercise5";
    });

    siloBuilder.ConfigureLogging(loggingBuilder =>
    {
        loggingBuilder.AddConsole();
    });

    siloBuilder.UseDashboard();
});

var host = builder.Build();
host.Run();