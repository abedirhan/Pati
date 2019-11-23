using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pati.Models;
using Pati.Services;

namespace Pati.Repository
{
    public class BasketRepository:IBasket
    {
        private DB_Context db;

        public BasketRepository(DB_Context _db)
        {
            db = _db;
        }

        public IEnumerable<Basket> GetBaskets => db.Baskets;
        public Basket GetBasket(int? id)
        {
            Basket dbEntity = db.Baskets.Find(id);
            return dbEntity;
        }

        public void Add(Basket basket)
        {
            db.Baskets.Add(basket);
            db.SaveChanges();
        }

        public void Remove(int? id)
        {
            Basket dbEntity = db.Baskets.Find(id);
            db.Baskets.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
