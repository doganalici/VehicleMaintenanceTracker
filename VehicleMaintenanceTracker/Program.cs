using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMaintenanceTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool state = true;
            Console.WriteLine("\tARAÇ BAKIM TAKİP SİSTEMİ");
            VehicleManager manager = new VehicleManager();

            while (state)
            {
                Console.WriteLine("Lütfen menüden bir tuşlama yapınız");
                Console.WriteLine("1 - Araç Ekle\n" +
                    "2 - Araçları Listele\n" +
                    "3 - Araç Sil\n" +
                    "4 - Bakım Ekle\n" +
                    "5 - Bakım Geçmişini Göster\n" +
                    "6 - Çıkış\n" +
                    "*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n ");
                Console.Write("Seçiminiz : ");
                int option;
                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.Write("Hatalı giriş! Lütfen sayı giriniz: ");
                }
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("ARAÇ EKLE");
                        Console.WriteLine("---------------");
                        Console.WriteLine("Eklemek istediğiniz araç tipi nedir?\n" +
                            "1 - Araba\n" +
                            "2 - Kamyon\n");
                        Console.Write("Seçiminiz : ");
                        int carType;
                        while (!int.TryParse(Console.ReadLine(), out carType))
                        {
                            Console.Write("Hatalı giriş! Lütfen sayı giriniz: ");
                        }
                        if (carType == 1 || carType == 2)
                        {


                            Console.Write("Id : ");
                            int id;
                            while (!int.TryParse(Console.ReadLine(), out id))
                            {
                                Console.Write("Hatalı giriş! Lütfen sayı giriniz: ");
                            }

                            Console.Write("Plaka : ");
                            string plate = Console.ReadLine();

                            Console.Write("Marka : ");
                            string brand = Console.ReadLine();

                            Console.Write("Model : ");
                            string model = Console.ReadLine();

                            Console.Write("Renk : ");
                            string color = Console.ReadLine();

                            Console.Write("Yıl : ");
                            int year;
                            while (!int.TryParse(Console.ReadLine(), out year))
                            {
                                Console.Write("Hatalı giriş! Lütfen sayı giriniz: ");
                            }

                            Vehicle newVehicle = null;
                            if (carType == 1)
                            {
                                Console.Write("Kapı Sayısı : ");
                                int door;
                                while (!int.TryParse(Console.ReadLine(), out door))
                                {
                                    Console.Write("Hatalı giriş! Lütfen sayı giriniz: ");
                                }
                                newVehicle = new Car(id, plate, brand, model, color, year, door);

                            }
                            else if (carType == 2)
                            {
                                Console.Write("Yük Kapasitesi : ");
                                int loadCapacity;
                                while (!int.TryParse(Console.ReadLine(), out loadCapacity))
                                {
                                    Console.Write("Hatalı giriş! Lütfen sayı giriniz: ");
                                }
                                newVehicle = new Truck(id, plate, brand, model, color, year, loadCapacity);
                            }

                            Console.Clear();
                            bool added = manager.AddVehicle(newVehicle);
                            if (added)
                            {
                                Console.Clear();
                                Console.WriteLine("Araç başarıyla eklendi.\n");
                            }
                            else
                            {
                                Console.WriteLine("Araç eklenemedi. Devam etmek için bir tuşa basınız...");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Hatalı tuşlama yaptınız!!!");
                            Console.WriteLine("Devam etmek için bir tuşa basınız...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("ARAÇLARI LİSTELE");
                        Console.WriteLine("-----------------");
                        manager.ListVehicles();
                        Console.WriteLine("Devam etmek için bir tuşa basınız...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("ARAÇ SİL");
                        Console.WriteLine("-----------------");
                        Console.Write("Silmek istediğiniz plakayı yazınız : ");
                        string removePlate = Console.ReadLine();
                        manager.RemoveVehicle(removePlate);
                        Console.WriteLine("Devam etmek için bir tuşa basınız");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("BAKIM EKLE");
                        Console.WriteLine("-----------------");
                        Console.Write("Bakıma eklenecek arabanın plakasını yazınız : ");
                        string maintenancePlate = Console.ReadLine();
                        if (!manager.IsVehicleExists(maintenancePlate))
                        {
                            Console.WriteLine("Araç bulunamadı!");
                            Console.WriteLine("Devam etmek için bir tuşa basınız...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        Console.Write("Tarih giriniz (GG.AA.YYYY) : ");
                        DateTime maintenanceDate;
                        while (!DateTime.TryParse(Console.ReadLine(), out maintenanceDate))
                        {
                            Console.Write("Hatalı giriş! Lütfen geçerli bir tarih giriniz: ");
                        }
                        Console.Write("Açıklama giriniz : ");
                        string maintenanceExplanation = Console.ReadLine();
                        Console.Write("Ücret giriniz (TL) : ");
                        int maintenancePayment;
                        while (!int.TryParse(Console.ReadLine(), out maintenancePayment))
                        {
                            Console.Write("Hatalı giriş! Lütfen geçerli bir tutar giriniz: ");
                        }
                        MaintenanceRecord maintenanceRecord = new MaintenanceRecord(maintenanceDate, maintenanceExplanation, maintenancePayment);
                        manager.AddMaintenance(maintenancePlate, maintenanceRecord);
                        Console.WriteLine("Devam etmek için bir tuşa basınız");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("BAKIM GEÇMİŞİNİ GÖSTER");
                        Console.WriteLine("-----------------");
                        Console.Write("Bakım geçmişi gösterilecek arabanın plakasını yazınız : ");
                        string showMaintenance = Console.ReadLine();
                        manager.ShowMaintenance(showMaintenance);
                        Console.WriteLine("Devam etmek için bir tuşa basınız");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.Write("Çıkış yapılıyor. Lütfen bir tuşa basınız");
                        state = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Menü dışındaki bir rakam tuşlaması yaptınız. Lütfen tekrar deneyin!!!\n");
                        break;
                }
            }
        }
    }
}
