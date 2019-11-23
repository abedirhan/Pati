using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pati.Models;

namespace Pati.Services
{
   public  interface IProduct
    {
        IEnumerable<Product> GetProducts { get; }
        Product GetProduct(int? id);
        void Add(Product product);
        void Remove(int? id);
    }
}
