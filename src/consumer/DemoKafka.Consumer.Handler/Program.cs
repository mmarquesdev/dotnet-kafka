using DemoKafka.Consumer.Handler.Handlers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IHostedService, MessageHandler>();


var app = builder.Build();
app.Run();
