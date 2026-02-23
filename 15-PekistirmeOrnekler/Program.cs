using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _15_PekistirmeOrnekler
{

    class BankaHesap
    {
        public decimal Bakiye { get; private set; }

        public void ParaYatir(decimal tutar)
        {
            
            if (tutar <= 0)
            {
                Console.WriteLine("Geçersiz değer girdiniz");
                return;
            }

            Bakiye = Bakiye + tutar;

            Console.WriteLine($"Güncel Bakiye: {Bakiye}");
        }
        public void ParaCek(decimal tutar)
        {
            
            if (tutar <= 0) 
            {
                Console.WriteLine("Geçersiz değer girdiniz");
                return;
            }
            if(tutar > Bakiye)
            {
                Console.WriteLine("Yetersiz bakiye!");
                return;
            }

            Bakiye -= tutar;

            Console.WriteLine($"Güncel Bakiye: {Bakiye}");
        }
    }
    enum TicketPriority { Low, Medium, High, Critical }
    enum TicketStatus { Open, InProgress, Resolved, Closed }
    class TicketSistemi
    {
        public TicketSistemi()
        {
            Status = TicketStatus.Open;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
        public string Title{ get; set; }
        public string Description { get; set; }
        public TicketPriority Priority { get; private set; }
        public TicketStatus Status { get; private set; }
        public  DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set;}
        
        
        public void SetPriority(int secim)
        {
            if (secim == 4)
            {
                Priority = TicketPriority.Critical;
            }
            else if(secim == 3)
            {
                Priority = TicketPriority.High;
            }
            else if(secim == 2)
            {
                Priority = TicketPriority.Medium;
            }
            else if( secim == 1)
            {
                Priority = TicketPriority.Low;
            }
            else
            {
                Console.WriteLine("Hatalı değer girdiniz!");
                return;
            }
            UpdatedAt = DateTime.Now;
        }

        public void TicketStart()
        {
            if(Status != TicketStatus.Open)
            {
                Console.WriteLine("Önce çözülmeli");
                return;
            }
            Status = TicketStatus.InProgress;
            UpdatedAt = DateTime.Now;
        }
        public void TicketInProgress()
        {
            if(Status != TicketStatus.InProgress)
            {
                Console.WriteLine("Önce çözülmeli");
                return;
            }
            Status = TicketStatus.Resolved;
            UpdatedAt = DateTime.Now;
        }
        public void TicketResolved()
        {
            if(Status != TicketStatus.Resolved)
            {
                Console.WriteLine("Önce çözülmeli");
                return;
            }
            Status = TicketStatus.Closed;
            UpdatedAt = DateTime.Now;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Banka hesaba para yatırma çekme
            /*
            BankaHesap hesap = new BankaHesap();
            decimal tutar;
            int islem;
            do
            {
                Console.WriteLine("Bakiye: " + hesap.Bakiye);
                Console.WriteLine("Lütfen yapmak istediğin işlemi seç");
                Console.WriteLine("0 - Çıkış\n1 - Para Yatırmak\n2 - Para Çekmek");
                islem = Convert.ToInt32(Console.ReadLine());
            
                if (islem == 1)
                {
                    Console.WriteLine("Lütfen yatırmak istediğiniz tutarı giriniz.");
                    tutar = Convert.ToDecimal(Console.ReadLine());
                    hesap.ParaYatir(tutar);
                }
                else if (islem == 2)
                {
                    Console.WriteLine("Lütfen çekmek istediğiniz tutarı giriniz");
                    tutar = Convert.ToDecimal(Console.ReadLine());
                    hesap.ParaCek(tutar);
                }
                else if(islem == 0)
                {
                    Console.WriteLine("Çıkılıyor...");
                }
                else { Console.WriteLine("Hatalı değer girdiniz"); }
            } while (islem != 0);
            Console.WriteLine("Çıkış yapıldı!");
            */
            TicketSistemi ticketSistem = new TicketSistemi();
            Console.WriteLine("Yeni bir ticket açıyorsunuz!");

            Console.Write("Ticket Başlığı: ");
            string baslik = Console.ReadLine();
            ticketSistem.Title = baslik;
            
            Console.Write("Ticket Açıklaması: ");
            string aciklama = Console.ReadLine();
            ticketSistem.Description = aciklama;



            Console.WriteLine("Lütfen önceliği seçiniz:\n0 - Çıkış\n1 - Low\n2 - Medium\n3 - High\n4 - Critical");
            
            do
            {
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 0)
                {
                    return;
                }
                else if(secim >= 1 && secim <= 4)
                {
                    ticketSistem.SetPriority(secim);
                    break;
                }
                else { Console.WriteLine("Geçersiz seçim"); continue; }
            } while (true);

            if (ticketSistem.Priority == TicketPriority.Critical && ticketSistem.Status == TicketStatus.Open)
            {
                Console.WriteLine("Aciliyeti yüksek kuyruğuna alındı");
            }


            Console.WriteLine("--------------------");
            Console.WriteLine($"Ticket Başlığı: {baslik}");
            Console.WriteLine($"Ticket Açıklaması: {aciklama}");
            Console.WriteLine($"Ticket Durum: {ticketSistem.Status}");
            Console.WriteLine($"Ticket Önceliği: {ticketSistem.Priority}");
            Console.WriteLine($"Güncelleme Tarihi: {ticketSistem.UpdatedAt}");
            Console.WriteLine("--------------------");



            Console.Read();
        }
    }
}
