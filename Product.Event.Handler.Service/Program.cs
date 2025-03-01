
using Product.Event.Handler.Service.Services;
using Shared.Services.Abstractions;
using Shared.Services.Concrete;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<EventStoreBackgroundService>();

builder.Services.AddSingleton<IEventStoreService, EventStoreService>();
builder.Services.AddSingleton<IMongoDBService, MongoDBService>();
var host = builder.Build();
host.Run();
