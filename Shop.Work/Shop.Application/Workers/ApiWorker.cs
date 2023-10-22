public class ApiWorker : BackgroundService
{
    readonly ILogger<ApiWorker> _logger;

    public ApiWorker(ILogger<ApiWorker> logger)
    {
        _logger = logger;
    }

    protected async override Task ExecuteAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Service started.");

        while (!cancellationToken.IsCancellationRequested)
        {
            _logger.LogInformation("Worker running at :{time}", DateTimeOffset.Now);
            await Task.Delay(1000, cancellationToken);
        }
    }
}