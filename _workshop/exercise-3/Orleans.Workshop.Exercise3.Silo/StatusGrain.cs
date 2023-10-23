namespace Orleans.Workshop.Exercise3.Silo;

public interface IStatusGrain : IGrainWithGuidKey
{
    Task<string> GetStatus();
}

public class StatusGrain : Grain, IStatusGrain
{
    public Task<string> GetStatus()
    {
        return Task.FromResult($"{DateTime.Now}");
    }
}