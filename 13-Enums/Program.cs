using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Enums
{
    internal class Program
    {
        //Enum (Numaratör) lar nesneleri numaralandırmak için kullanılır.
        //Enumlarda Türkçe karakter kullanılabiliyor ancak boşluk kullanılamıyor.

        enum Aylar : byte
        {
            Ocak,
            Şubat,
            Mart,
            Nisan,
            Mayıs,
            Haziran,
            Temmuz,
            Ağustos,
            Eylül,
            Ekim,
            Kasım,
            Aralık
        }
        enum CalismaGunler
        {
            Pazartesi,
            Salı,
            Çarşamba,
            Perşembe,
            Cuma
        }
        enum SiparisDurumu
        {
            Hazırlanıyor,
            Hazırlandı,
            KargoBekleniyor,
            Kargolandı
        }
        enum Meyveler : int
        {
            Elma = 3,
            Armut = 7,
            Çilek = 1
        }
        enum TicketStatus
        {
            Open,
            InProgress,
            Resolved,
            Closed
        }
        enum TicketPriority
        {
            Low,
            Medium,
            High,
            Critical
        }
        static void Main(string[] args)
        {
            byte a = (byte)Meyveler.Elma;
            byte b = (byte)Meyveler.Armut;
            byte c = (byte)Meyveler.Çilek;
            Console.WriteLine($"Elma = {a}, Armut = {b}, Çilek = {c}");

            //Ornek();
            TicketSystem();
            Console.Read();
        }

        static void Ornek()
        {
            int SiparisDurum = 3;
            if (SiparisDurum == 0) Console.WriteLine("Sipariş Durumu: {0}", SiparisDurumu.Hazırlanıyor);
            if (SiparisDurum == 1) Console.WriteLine("Sipariş Durumu: {0}", SiparisDurumu.Hazırlandı);
            if (SiparisDurum == 2) Console.WriteLine("Sipariş Durumu: {0}", SiparisDurumu.KargoBekleniyor);
            if (SiparisDurum == 3) Console.WriteLine("Sipariş Durumu: {0}", SiparisDurumu.Kargolandı);
        }
        /*----------Pekiştirme örneği Ticket Sistemi-----------------*/
        static void TicketSystem()
        {
            Console.WriteLine("Lütfen ticket başlığını giriniz.");
            string ticketBaslik = Console.ReadLine();
            Console.WriteLine("Lütfen açıklamanızı giriniz.");
            string ticketAciklama = Console.ReadLine();
            Console.WriteLine("Lütfen öncelik derecesini belirtin.");
            
            int ticketDerece;
            do
            {
                Console.WriteLine("Öncelik seçiniz: \n1 - Low\n2 - Medium\n3 - High\n4 - Critical");
                ticketDerece = Convert.ToInt32(Console.ReadLine());
                if (ticketDerece < 1 || ticketDerece > Enum.GetValues(typeof(TicketPriority)).Length)
                {
                    Console.WriteLine("Geçersiz seçim, 1-4 arası giriniz.");
                    continue;
                }
                break;
            } while (true);

            int ticketDurum;
            do
            {
                Console.WriteLine("Durum seçiniz: \n1 - Open\n2 - InProgress\n3 - Resolved\n4 - Closed");
                ticketDurum = Convert.ToInt32(Console.ReadLine());
                if (ticketDurum < 1 || ticketDurum > Enum.GetValues(typeof(TicketStatus)).Length)
                {
                    Console.WriteLine("Geçersiz seçim, 1-4 arası giriniz.");
                    continue;
                }
                break;
            } while (true);
            



            TicketPriority priority = (TicketPriority)(ticketDerece - 1);
            TicketStatus status = (TicketStatus)(ticketDurum - 1);

            if (priority == TicketPriority.Critical && status == TicketStatus.Open)
            {
                Console.WriteLine("Acil müdahale kuyruğuna alındı");
            }

            switch (status)
            {
                case TicketStatus.Open:
                    Console.WriteLine("Ticket oluşturuldu!");
                    break;
                case TicketStatus.InProgress:
                    Console.WriteLine("Ticket işleme alındı!");
                    break;
                case TicketStatus.Resolved:
                    Console.WriteLine("Sorun çözüldü!");
                    break;
                case TicketStatus.Closed:
                    Console.WriteLine("Ticket Kapatıldı!");
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Başlık: {ticketBaslik}\nAçıklama: {ticketAciklama}\nÖncelik Derecesi: {priority}\nAnlık Durumu: {status}");

        }
    }
}
