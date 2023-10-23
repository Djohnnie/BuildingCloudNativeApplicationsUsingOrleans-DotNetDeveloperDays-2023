using Orleans.Configuration;
using Orleans.Workshop.Exercise5.Client;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.UseOrleansClient(clientBuilder =>
{
    clientBuilder.Configure<ClusterOptions>(options =>
    {
        options.ClusterId = "orleans-exercise5";
        options.ServiceId = "orleans-exercise5";
    });

    clientBuilder.UseLocalhostClustering(30001, "orleans-exercise5", "orleans-exercise5");
});

var host = builder.Build();
host.Run();