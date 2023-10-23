using Orleans.Configuration;
using Orleans.Workshop.Exercise6.Client;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.UseOrleansClient(clientBuilder =>
{
    clientBuilder.Configure<ClusterOptions>(options =>
    {
        options.ClusterId = "orleans-exercise6";
        options.ServiceId = "orleans-exercise6";
    });

    clientBuilder.UseLocalhostClustering(30001, "orleans-exercise6", "orleans-exercise6");
});

var host = builder.Build();
host.Run();