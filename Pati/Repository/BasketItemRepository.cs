using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pati.Models;
using Pati.Services;

namespace Pati.Repository
{
    public class BasketItemRepository:IBasketItem
    {
        private DB_Context db;

        public BasketItemRepository(DB_Context _db)
        {
            db = _db;
        }

        public IEnumerable<BasketItem> GetBasketItems => db.BasketItems;
        public BasketItem GetBasketItem(int? id)
        {
            BasketItem dbEntity = db.BasketItems.Find(id);
            return dbEntity;
        }

        public void Add(BasketItem basketItem)
        {
            db.BasketItems.Add(basketItem);
            db.SaveChanges();
        }

        public void Remove(int? id)
        {
            BasketItem dbEntity = db.BasketItems.Find(id);
            db.BasketItems.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
