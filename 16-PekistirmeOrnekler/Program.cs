using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _16_PekistirmeOrnekler
{
    //2D Nokta Koordinat Sistemi
    /*  
        🎯 Senaryomuz
        Harita / oyun / çizim uygulaması geliştiriyorsun
        Her noktanın x ve y koordinatı olmak zorunda
    */
    interface Inokta
    {
        int X { get; set; }
        int Y { get; set; }
    }
    class Nokta2D : Inokta
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Inokta n = new Nokta2D();
            n.X = 5;
            n.Y = 10;
            Console.WriteLine(n.X + n.Y);
            */
            INotification notification = null;

            Console.Write("Mesaj: ");
            string message = Console.ReadLine();

            int yontem;

            do
            {
                Console.WriteLine("Lütfen bildirim gönderim tipi seçiniz: \n0-Çıkış\n1-Email Gönderim\n2-Sms Gönderim\n3-Push Gönderim");
                yontem = Convert.ToInt32(Console.ReadLine());

                if (yontem < 0 || yontem > 3)
                {
                    Console.WriteLine("Hatalı değer girdiniz");
                }
                if (yontem == 1)
                {
                    notification = new EmailNotification();
                    notification.Send(message);
                    break;
                }
                if (yontem == 2)
                {
                    notification = new SmsNotification();
                    notification.Send(message);
                    break;
                }
                if (yontem == 3)
                {
                    notification = new PushNotification();
                    notification.Send(message);
                    break;
                }
            } while (yontem != 0);
            

                Console.Read();
        }
    }
    interface INotification
    {
        void Send(string message);
    }
    class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Email gönderildi!");
        }
    }
    class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Sms gönderildi!");
        }
    }
    class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Push gönderildi!");
        }
    }
}
