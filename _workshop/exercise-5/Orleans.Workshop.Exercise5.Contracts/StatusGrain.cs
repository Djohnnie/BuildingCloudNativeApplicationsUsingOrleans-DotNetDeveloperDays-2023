namespace Orleans.Workshop.Exercise5.Contracts;

public interface IStatusGrain : IGrainWithGuidKey
{
    Task<string> GetStatus();
}