using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMaintenanceTracker
{
    public abstract class Vehicle
    {
        List<MaintenanceRecord> records = new List<MaintenanceRecord>();
        public int Id { get; set; }
        public string Plate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public abstract void DisplayInfo();


        public void AddRecord(MaintenanceRecord record)
        {
            records.Add(record);
        }

        public void ShowRecord()
        {
            if (records.Count == 0)
            {
                Console.WriteLine("Bu araç için bakım kaydı yok !!!");
                return;
            }
            Console.WriteLine($"\n-- {Plate} plakalı aracın bakım geçmişi --\n");
            foreach (var r in records)
            {
                r.Display();
            }
            
        }
    }
}
