namespace Orleans.Workshop.Exercise4.Silo;

public class Worker : BackgroundService
{
    private readonly IGrainFactory _grainFactory;
    private readonly ILogger<Worker> _logger;

    public Worker(
        IGrainFactory grainFactory,
        ILogger<Worker> logger)
    {
        _logger = logger;
        _grainFactory = grainFactory;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await Task.Delay(1000);

        while (!stoppingToken.IsCancellationRequested)
        {
            var grain = _grainFactory.GetGrain<IStatusGrain>(Guid.NewGuid());
            var result = await grain.GetStatus();

            _logger.LogInformation(result);

            await Task.Delay(1000);
        }
    }
}