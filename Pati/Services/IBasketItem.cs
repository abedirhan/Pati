using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pati.Models;

namespace Pati.Services
{
   public  interface IBasketItem
    {
        IEnumerable<BasketItem> GetBasketItems { get; }
        BasketItem GetBasketItem(int? id);
        void Add(BasketItem basketItem);
        void Remove(int? id);

    }
}
