using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Entities.Interfaces;

internal interface IProductService
{
    void Add(string user, string productName);
}
