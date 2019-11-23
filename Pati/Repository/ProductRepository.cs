using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pati.Models;
using Pati.Services;

namespace Pati.Repository
{
    public class ProductRepository:IProduct
    {
        private DB_Context db;

        public ProductRepository(DB_Context _db)
        {
            db = _db;
        }

        public IEnumerable<Product> GetProducts => db.Products;
        public Product GetProduct(int? id)
        {
            Product dbEntity = db.Products.Find(id);
            return dbEntity;
        }

        public void Add(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();

        }

        public void Remove(int? id)
        {
            Product dbEntity = db.Products.Find(id);
            db.Products.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
