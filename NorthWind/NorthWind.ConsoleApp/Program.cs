
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;
using Microsoft.Extensions.DependencyInjection;

HostApplicationBuilder Builder  = Host.CreateApplicationBuilder();

Builder.Services.AddNorthWindServices()

Builder.Services.AddConsoleWriter();
Builder.Services.AddDebugWriter();
Builder.Services.AddFileWriter();
Builder.Services.AddSingleton<AppLoger>();
Builder.Services.AddSingleton<ProductService>();
using IHost AppHost = Builder.Build();


IAppLogger Logger = AppHost.Services.GetRequiredService<IAppLogger>();
Logger.Writelog("Aplication started.");

IProductService Service = AppHost.Services.GetRequiredService<IProductService>();
Service.Add("Demo", "Azucar refinida");

/*
 * Apploger y los Writers: Responsabilidad unica
 * Apploger: Abierto pero cerrado
 * Apploger: Inversion de dependecias. Los modulos 
 * de alto nivel son independencias de los datalles de implementacion
 * 
 * */ 