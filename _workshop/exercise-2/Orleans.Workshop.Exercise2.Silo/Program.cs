using Orleans.Configuration;
using Orleans.Workshop.Exercise2.Silo;
using System.Net;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.UseOrleans((siloBuilder) =>
{
    siloBuilder.UseLocalhostClustering(11111, 30001, primarySiloEndpoint: new IPEndPoint(IPAddress.Loopback, 11111), serviceId: "orleans-exercise2", clusterId: "orleans-exercise2");

    siloBuilder.Configure<ClusterOptions>(options =>
    {
        options.ClusterId = "orleans-exercise2";
        options.ServiceId = "orleans-exercise2";
    });

    siloBuilder.ConfigureLogging(loggingBuilder =>
    {
        loggingBuilder.AddConsole();
    });

    siloBuilder.UseDashboard();
});

var host = builder.Build();
host.Run();