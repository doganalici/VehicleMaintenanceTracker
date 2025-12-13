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
        public int Payment { get; set; }

        public MaintenanceRecord(DateTime date, string description,int payment)
        {
            Date = date;
            Description = description;
            Payment = payment;
        }

        public void Display()
        {
            Console.WriteLine($"Tarih: {Date:dd/MM/yyyy}\n" +
                $"Açıklama: {Description}\n" +
                $"Ücret : {Payment:N0} TL");
            Console.WriteLine("*******************");
        }
    }
}
