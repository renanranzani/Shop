using Shop.Work.Workers;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<ShopWorker>();
    })
    .Build();

host.Run();
