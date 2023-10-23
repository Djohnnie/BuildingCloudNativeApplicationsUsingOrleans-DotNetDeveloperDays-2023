using Orleans.Configuration;
using System.Net;

var siloPort = Convert.ToInt32(args[0]);
var gatewayPort = Convert.ToInt32(args[1]);
var primaryPort = Convert.ToInt32(args[2]);
var dashboardPort = Convert.ToInt32(args[3]);

var builder = Host.CreateApplicationBuilder(args);

builder.UseOrleans((siloBuilder) =>
{
    siloBuilder.UseLocalhostClustering(siloPort, gatewayPort, primarySiloEndpoint: new IPEndPoint(IPAddress.Loopback, primaryPort), serviceId: "orleans-exercise6", clusterId: "orleans-exercise6");

    siloBuilder.Configure<ClusterOptions>(options =>
    {
        options.ClusterId = "orleans-exercise6";
        options.ServiceId = "orleans-exercise6";
    });

    siloBuilder.ConfigureLogging(loggingBuilder =>
    {
        loggingBuilder.AddConsole();
    });

    siloBuilder.UseDashboard(c => c.Port = dashboardPort);
});

var host = builder.Build();
host.Run();