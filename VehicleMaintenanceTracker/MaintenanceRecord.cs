using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMaintenanceTracker
{
    public class MaintenanceRecord
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public MaintenanceRecord(DateTime date, string description)
        {
            Date = date;
            Description = description;
        }

        public void Display()
        {
            Console.WriteLine($"Tarih: {Date:dd/MM/yyyy} | Açıklama: {Description}");
        }
    }
}
