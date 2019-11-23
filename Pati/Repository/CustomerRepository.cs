using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pati.Models;
using Pati.Services;

namespace Pati.Repository
{
    public class CustomerRepository:ICustomer
    {
        private DB_Context db;

        public CustomerRepository(DB_Context _db)
        {
            db = _db;
        }

        public IEnumerable<Customer> GetCustomers => db.Customers;
        public Customer GetCustomer(int? id)
        {
            Customer dbEntity = db.Customers.Find(id);
            return dbEntity;
        }

        public void Add(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
        }

        public void Remove(int? id)
        {
            Customer dbEntity = db.Customers.Find(id);
            db.Customers.Remove(dbEntity);
            db.SaveChanges();

        }
    }
}
