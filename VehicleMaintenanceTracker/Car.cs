using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMaintenanceTracker
{
    public class Car : Vehicle
    {
        public int Door { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"[ARABA] ;\n" +
                $"ID : {Id}\n" +
                $"Plaka : {Plate}\n" +
                $"Marka : {Brand}\n" +
                $"Model : {Model}\n" +
                $"Renk : {Color}\n" +
                $"Yıl : {Year}\n" +
                $"Kapı Sayısı : {Door}\n");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
        }
        public Car(int id, string plate, string brand, string model, string color, int year, int door)
        {
            Id = id;
            Plate = plate;
            Brand = brand;
            Model = model;
            Color = color;
            Year = year;
            Door = door;
        }
    }
}
