namespace Orleans.Workshop.Exercise4.Silo;

public interface IStatusGrain : IGrainWithGuidKey
{
    Task<string> GetStatus();
}

public class StatusGrain : Grain, IStatusGrain
{
    public Task<string> GetStatus()
    {
        DeactivateOnIdle();
        return Task.FromResult($"{DateTime.Now}");
    }
}