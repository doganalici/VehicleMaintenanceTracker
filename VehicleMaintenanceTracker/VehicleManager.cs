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
        public bool AddVehicle(Vehicle v)
        {
            if (v == null)
            {
                Console.WriteLine("Araç oluşturulamadı! ");
                return false;
            }
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.Id == v.Id)
                {
                    Console.WriteLine($"{vehicle.Id} numaralı Id zaten kayıtlı !!!");
                    return false;
                }
                if (vehicle.Plate == v.Plate)
                {
                    Console.WriteLine($"{vehicle.Plate} plakasında bir araç zaten kayıtlı !!!");
                    return false;
                }
            }
            vehicles.Add(v);
            return true;
            //Console.WriteLine("Araç başarıyla eklendi :)");
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
                Console.WriteLine($"{plate} Plakalı araç başarıyla silindi.\n");
            }
            else
            {
                Console.WriteLine("Bu plakada bir araç bulunamadı.\n");
            }
        }

        public void ListVehicles()
        {
            if (vehicles.Count == 0)
            {
                Console.WriteLine("Kayıtlı araç bulunmamaktadır!");
                return;
            }
            foreach (var v in vehicles)
            {
                v.DisplayInfo();
                Console.WriteLine("-------------------");
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

        public bool IsVehicleExists(string plate)
        {
            foreach (var v in vehicles)
            {
                if (v.Plate == plate)
                {
                    return true;
                }
            }
            return false;
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
