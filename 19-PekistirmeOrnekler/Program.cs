using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_PekistirmeOrnekler
{
    /*
    ==========================
    SOLID (Kısa + Proje Üzerinden)
    ==========================

    S — Single Responsibility Principle (Tek Sorumluluk)
    - Her class / metot tek bir işi yapmalı.
    - Örn: PaymentEngine sadece "ödeme akışını" yönetir.
      Log yazma / mail gönderme / sms atma gibi işler PaymentEngine'in işi değildir.
    - Kazanç: Kod şişmez, bakımı kolaylaşır, test yazmak kolaylaşır.

    O — Open/Closed Principle (Genişletmeye Açık, Değişikliğe Kapalı)
    - Yeni özellik eklerken mevcut kodu kırmadan/ değiştirmeden ekleme yapabilmeliyim.
    - Örn: Yeni ödeme yöntemi eklemek için PaymentEngine içine if/else eklemek yerine;
      yeni bir metot yazar, sisteme "kayıt ederim" (strategy/delegate/dictionary ile).
    - Kazanç: Yeni eklemeler daha güvenli, refactor maliyeti düşer.

    L — Liskov Substitution Principle (Yerine Geçebilirlik)
    - Bir base sınıf bekleniyorsa, onun yerine child sınıf verildiğinde sistem bozulmamalı.
    - Örn: Employee base'inden türeyen Developer/Manager her yerde Employee gibi davranabilmeli.
    - Kırmızı bayrak: Child class base davranışını bozuyorsa (beklenmeyen exception/ davranış) LSP ihlalidir.

    I — Interface Segregation Principle (Arayüzleri Böl)
    - Devasa interface yerine küçük ve amaç odaklı interface’ler.
    - Örn: INotification diye tek bir interface yapıp herkesin içinde Email/Sms/Push zorlamak yerine:
      IEmailSender, ISmsSender, ILogWriter gibi küçük arayüzler.
    - Kazanç: Gereksiz metot implement etmezsin, bağımlılık azalır.

    D — Dependency Inversion Principle (Bağımlılığı Tersine Çevir)
    - High-level (iş kuralları) low-level (detay implementasyon) sınıflara bağımlı olmamalı.
    - İkisi de soyuta (interface/abstraction) bağımlı olmalı.
    - Örn: PaymentEngine doğrudan MailService sınıfını çağırmaz.
      Bunun yerine bir event yayınlar veya INotification gibi soyut bir yapı üzerinden haber verir.
    - Kazanç: Test kolay, değiştirme kolay (MailService değişir, engine değişmez).

    ==========================
    Bu projede SOLID nasıl görünüyor?
    ==========================
    - SRP: PaymentEngine sadece ödeme yapıyor; LogYaz/MailGonder ayrı metotlar.
    - OCP: Yeni bir bildirim eklemek (SmsGonder gibi) engine'i değiştirmeden sadece event'e abone olmak.
    - DIP: Engine subscriber'ları tanımıyor; sadece event yayınlıyor (loosely coupled).
    */
    class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public double TotalAmount { get; set; }
    }
    class PaymentEngine
    {
        public event Action<Order> PaymentSucceeded;

        public void SimulatePayment(Order order)
        {
            Console.WriteLine("Ödeme başarılı");
            PaymentSucceeded?.Invoke(order);
        }
    }
    internal class Program
    {
        static void LogYaz(Order o)
        {
            Console.WriteLine($"Log: ödeme başarılı \nMüşteri: {o.CustomerName}\nÖdeme Tutarı: {o.TotalAmount}");
        }
        static void MailGonder(Order o)
        {
            Console.WriteLine($"Mail: Mail gönderildi! \nMüşteri: {o.CustomerName}\nÖdeme Tutarı: {o.TotalAmount}");
        }
        static void Main(string[] args)
        {
            Order order = new Order 
            {
                Id = 1,
                CustomerName = "Enes",
                TotalAmount = 1500
            };
            
            PaymentEngine engine = new PaymentEngine();
            engine.PaymentSucceeded += LogYaz;
            engine.PaymentSucceeded += MailGonder;
            engine.SimulatePayment(order);



        }
    }
}
