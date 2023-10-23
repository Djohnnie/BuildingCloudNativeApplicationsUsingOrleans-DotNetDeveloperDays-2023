namespace Orleans.Workshop.Exercise6.Contracts;

public interface IStatusGrain : IGrainWithGuidKey
{
    Task<string> GetStatus();
}