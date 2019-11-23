using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pati.Models;
using Pati.Services;

namespace Pati.Repository
{
    public class ShipmentRepository:IShipment
    {
        private DB_Context db;

        public ShipmentRepository(DB_Context _db)
        {
            db = _db;

        }

        public IEnumerable<Shipment> GetShipments => db.Shipments;
        public Shipment GetShipment(int? id)
        {
            Shipment dbEntity = db.Shipments.Find(id);
            return dbEntity;
        }

        public void Add(Shipment shipment)
        {
            db.Shipments.Add(shipment);
            db.SaveChanges();
        }

        public void Remove(int? id)
        {
            Shipment dbEntity = db.Shipments.Find(id);
            db.Shipments.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
