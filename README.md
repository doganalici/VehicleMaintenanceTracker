🚗 Vehicle Maintenance Tracker – Araç Bakım Takip Sistemi

Bu proje, C# ile geliştirilmiş, Nesne Yönelimli Programlama (OOP) prensiplerini temel alan bir araç ve bakım takip uygulamasıdır. Amaç; farklı türde araçları sisteme kaydedebilmek, listeleyebilmek ve araçlara bakım kayıtları ekleyebilmektir.

📌 Projenin Amacı<br>

Bu proje, OOP'in temel kavramlarını uygulamalı olarak öğrenmek için geliştirilmiştir:

* Inheritance (Kalıtım)

* Abstraction (Soyutlama)

* Polymorphism (Çok Biçimlilik)

* Encapsulation (Kapsülleme)

* Aynı zamanda kullanıcı, LINQ bilmediği için tüm işlemler temel döngüler ve klasik koleksiyon yönetimi ile yazılmıştır.

🔧 Özellikler<br>
✔ 1. Araç Yönetimi

Sisteme iki tip araç eklenebilir:

* Car (Araba)

--> Kapı sayısı bilgisi içerir

--> DisplayInfo() metodu kendine özgü şekilde çalışır

* Truck (Kamyon)

-->Yük kapasitesi bilgisi içerir

--> DisplayInfo() metodu kendine özgü şekilde çalışır

📌 Kullanılan OOP Yapıları:

Vehicle (abstract) → ortak özellik ve davranışlar

Car ve Truck → kalıtım yoluyla genişletilmiş sınıflar

DisplayInfo() → polymorphism ile her araçta farklı şekilde uygulanır

✔ 2. VehicleManager — Araç Kaydı Yönetimi

* Sınıfın görevleri:

--> Araç ekleme

--> Araç silme

--> Araç listeleme

--> Ayrıca sistem, aynı plakaya sahip araç eklemeye izin vermez.

```csharp
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
```


✔ 3. Bakım Kayıt Sistemi (Devam Ediyor)

Her araç kendi bakım kayıtlarını tutar.
Bu kayıtlar için MaintenanceRecord sınıfı oluşturulmuştur.

Araç üzerinde:

AddRecord()

ShowRecords()

metotları bulunur.

VehicleManager içerisinde bakım ekleme ve görüntüleme alt yapısı hazırlanmıştır:

```csharp
public void AddMaintenance(string plate, MaintenanceRecord m) { … }
public void ShowMaintenance(string plate) { … }
```

📌 Bu özellik geliştirme aşamasındadır.

📁 **Proje Yapısı**

```
VehicleMaintenanceTracker/
│
├── Vehicle.cs              → Soyut temel sınıf
├── Car.cs                  → Car sınıfı
├── Truck.cs                → Truck sınıfı
├── VehicleManager.cs       → Araç yönetimi
├── MaintenanceRecord.cs    → Bakım kayıt modeli
└── Program.cs              → Test ve konsol menüsü (gelecek adımlarda)
```


📅 Şu Ana Kadar Tamamlanan Adımlar

✔ Adım 1: Vehicle + Car + Truck sınıfları

✔ Adım 2: VehicleManager (add, remove, list)

✔ Adım 3: MaintenanceRecord + Vehicle bakım sistemi altyapısı

✔ Adım 4: Display & kayıt gösterme altyapısı

⏳ Adım 5: Menü sistemi + kullanıcı etkileşimi (DEVAM EDİLECEK)
