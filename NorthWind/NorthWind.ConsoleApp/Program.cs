
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;

IUserActionWriter writer = default;

AppLogger Logger = new AppLogger(writer);
Logger.Writelog("Aplication started."); 