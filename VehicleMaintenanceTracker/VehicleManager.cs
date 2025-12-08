using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMaintenanceTracker
{
    public class VehicleManager
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        public void AddVehicle(Vehicle v)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.Plate == v.Plate)
                {
                    Console.WriteLine("Bu plakada bir araç zaten kayıtlı !!!");
                    return;
                }
            }
            vehicles.Add(v);
            Console.WriteLine("Araç başarıyla eklendi :)");
        }
        public void RemoveVehicle(string plate)
        {
            Vehicle vehicleToRemove = null;

            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.Plate == plate)
                {
                    vehicleToRemove = vehicle;
                    break;
                }
            }
            if (vehicleToRemove != null)
            {
                vehicles.Remove(vehicleToRemove);
                Console.WriteLine("Araç başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Araç bulunamadı.");
            }
        }

        public void ListVehicles()
        {
            foreach (var v in vehicles)
            {
                v.DisplayInfo();
            }

        }

        public void AddMaintenance(string plate, MaintenanceRecord m)
        {
            Vehicle found = null;
            foreach (var v in vehicles)
            {
                if (v.Plate == plate)
                {
                    found = v;
                    break;
                }
            }

            if (found == null)
            {
                Console.WriteLine("Araç bulunamadı!");
                return;
            }

            found.AddRecord(m);
            Console.WriteLine("Bakım kaydı eklendi.");
        }

        public void ShowMaintenance(string plate)
        {
            Vehicle found = null;
            foreach (var v in vehicles)
            {
                if (v.Plate == plate)
                {
                    found = v;
                    break;
                }
            }

            if (found == null)
            {
                Console.WriteLine("Araç bulunamadı!");
                return;
            }

            found.ShowRecord();
        }
    }
}
