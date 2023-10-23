using Orleans.Workshop.Exercise6.Contracts;

namespace Orleans.Workshop.Exercise6.Silo;

public class StatusGrain : Grain, IStatusGrain
{
    public Task<string> GetStatus()
    {
        return Task.FromResult($"{DateTime.Now}");
    }
}