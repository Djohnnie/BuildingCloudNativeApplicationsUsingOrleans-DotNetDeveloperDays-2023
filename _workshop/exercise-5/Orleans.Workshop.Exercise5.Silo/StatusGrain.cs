using Orleans.Workshop.Exercise5.Contracts;

namespace Orleans.Workshop.Exercise5.Silo;

public class StatusGrain : Grain, IStatusGrain
{
    public Task<string> GetStatus()
    {
        DeactivateOnIdle();
        return Task.FromResult($"{DateTime.Now}");
    }
}