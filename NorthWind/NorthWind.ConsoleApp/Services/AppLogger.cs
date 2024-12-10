using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWind.Entities.Interfces;
using NorthWind.Entities.ValueObjects;

namespace NorthWind.ConsoleApp.Services;

internal class AppLogger(IUserActionWriter writer)
{
    public void Writelog(string message)
    {
        UserAction Log = new UserAction("System", message);
        writer.Write(Log);
    }
}
 