using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

builder.Services.AddOcelot();

//builder.Services.AddCors(opt =>
//{
//    opt.AddDefaultPolicy(bu =>
//    {
//        bu.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
//    });
//});

var app = builder.Build();

//app.UseCors();

app.UseOcelot().Wait();

app.Run();