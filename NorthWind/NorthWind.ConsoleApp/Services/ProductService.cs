using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.ConsoleApp.Services;

internal class ProductService(IUserActionWriter writer)
{
    public void Add(string user, string poductName)
    {
        UserAction Action = new UserAction(user, poductName);
        writer.Write(Action);
    }
}
