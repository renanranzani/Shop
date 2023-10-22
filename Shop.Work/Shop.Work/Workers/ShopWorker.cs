namespace Shop.Work.Workers
{
    public class ShopWorker : BackgroundService
    {
        private readonly ILogger<ShopWorker> _logger;

        public ShopWorker(ILogger<ShopWorker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}