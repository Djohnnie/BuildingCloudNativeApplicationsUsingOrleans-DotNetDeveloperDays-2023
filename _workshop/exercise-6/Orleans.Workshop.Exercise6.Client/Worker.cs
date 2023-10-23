using Orleans.Workshop.Exercise6.Contracts;

namespace Orleans.Workshop.Exercise6.Client;

public class Worker : BackgroundService
{
    private readonly IClusterClient _grainFactory;
    private readonly ILogger<Worker> _logger;

    public Worker(
        IClusterClient grainFactory,
        ILogger<Worker> logger)
    {
        _logger = logger;
        _grainFactory = grainFactory;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await Task.Delay(10000);

        while (!stoppingToken.IsCancellationRequested)
        {
            var grain = _grainFactory.GetGrain<IStatusGrain>(Guid.NewGuid());
            var result = await grain.GetStatus();

            _logger.LogInformation(result);

            await Task.Delay(100);
        }
    }
}
