using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_StringClass
{
    internal class Pekistirme
    {
        public static void TcKontrol()
        {
            Console.WriteLine("Lütfen TC Kimlik Numaranızı giriniz: ");
            string tcKimlik = Console.ReadLine();
            if (tcKimlik.Length != 11)
            {
                Console.WriteLine("TC kimlik numarası 11 haneli olmalıdır!");
                return;
            }
            if (tcKimlik[0] == '0')
            {
                Console.WriteLine("TC kimlik numarası 0 ile başlayamaz");
                return;
            }

            for (int i = 0; i < tcKimlik.Length; i++)
            {
                if (!char.IsDigit(tcKimlik[i]))
                {
                    Console.WriteLine("TC sadece rakamdan oluşmalıdır.");
                    return;
                }
            }
            Console.WriteLine("TC format olarak geçerlidir.");
        }
        public static void EmailKontrol()
        {
            Console.WriteLine("Lütfen email adresinizi giriniz.");
            string email = Console.ReadLine();

            email = email.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Email adresi boş olamaz");
                return;
            }

            if (email.Contains(" "))
            {
                Console.WriteLine("Email adresinde boşluk olamaz");
                return;
            }

            int atIndex = email.IndexOf('@');
            if (atIndex == -1)
            {
                Console.WriteLine("@ işareti eksik, mail adresini doğru giriniz");
                return;
            }

            if (atIndex != email.LastIndexOf('@'))
            {
                Console.WriteLine("Email adresinde birden fazla @ olamaz");
                return;
            }

            if (atIndex == 0)
            {
                Console.WriteLine("Email adresi @ ile başlayamaz");
                return;
            }

            if (atIndex == email.Length - 1)
            {
                Console.WriteLine("Email adresi @ ile bitemez");
                return;
            }

            if (email[atIndex - 1] == '.')
            {
                Console.WriteLine("@ işaretinden önce . olamaz");
                return;
            }

            if (email[atIndex + 1] == '.')
            {
                Console.WriteLine("@ işaretinden sonra . olamaz");
                return;
            }

            int dotIndex = email.IndexOf('.', atIndex);
            if (dotIndex == -1)
            {
                Console.WriteLine("@ işaretinden sonra . olmalı");
                return;
            }

            if (dotIndex == email.Length - 1)
            {
                Console.WriteLine("Email adresi . ile bitemez");
                return;
            }

            if (email.Contains(".."))
            {
                Console.WriteLine("Email adresinde '..' olamaz");
                return;
            }

            int lastDot = email.LastIndexOf('.');
            int tldLen = email.Length - lastDot - 1;

            if (tldLen < 2)
            {
                Console.WriteLine("Uzantı en az 2 karakter olmalı (örn: .com)");
                return;
            }

            Console.WriteLine("Email formatı geçerli");
        }
    }
}
