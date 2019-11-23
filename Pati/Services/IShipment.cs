using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pati.Models;

namespace Pati.Services
{
    public interface IShipment
    {
        IEnumerable<Shipment> GetShipments { get; }
        Shipment GetShipment(int? id);
        void Add(Shipment shipment);
        void Remove(int? id);
    }
}
