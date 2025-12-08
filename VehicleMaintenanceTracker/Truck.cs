using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMaintenanceTracker
{
    public class Truck : Vehicle
    {
        public int LoadCapacity { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"[KAMYON] ;\n" +
                 $"ID : {Id}\n" +
                 $"Plaka : {Plate}\n" +
                 $"Marka : {Brand}\n" +
                 $"Model : {Model}\n" +
                 $"Renk : {Color}\n" +
                 $"Yıl : {Year}\n" +
                 $"Yük kapasitesi : {LoadCapacity} KG\n");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
        }
    }
}
