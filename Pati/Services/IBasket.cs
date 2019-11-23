using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pati.Models;

namespace Pati.Services
{
    public interface IBasket
    {
        IEnumerable<Basket> GetBaskets { get; }
        Basket GetBasket(int? id);
        void Add(Basket basket);
        void Remove(int? id);

    }
}
