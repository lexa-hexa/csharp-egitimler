using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_StringClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bazı yazıların altı renkli çizgili olur ve ne anlama geldiklerini açıklamak istedim
            //Kırmızı --> Bu hata çizgisidir üzerine geldiğimizde hata detaylarını görürüz
            //Sarı --> Bu uyarı çizgisidir ve gelecekte bu kodun bozulma olasılığı olduğunu söyler
            //Yeşil --> Bu gereksiz olduğunu belirtir örnek bir değişkeni bir yerde kullanmazsanız altı yeşil çizgi olur yani gereksiz olduğunu belirtir.

            string degisken;
            char karakter;
            string metinlericin = "Metin yazısı";
            Console.WriteLine(metinlericin);

            Ornek1();

            StringMetotlari();
            Kiyasla();


            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-------Login Simülasyonu----------");
            Login();
            
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-------TC kontrol Simülasyonu----------");
            Pekistirme.TcKontrol();
            
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-------Email Kontrol Simülasyonu----------");
            Pekistirme.EmailKontrol();
            
            Console.Read();

        }
        static void Ornek1()
        {
            string birMetin = "Ankara Başkenttir.";
            String birsayi = "1234567890";
            System.String birTarih = "26.06.2026";
            string s = "Barış Akarsu";
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(" s [ " + i + " ] = " + s[i]);
            }
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(birMetin.GetType());
            Console.WriteLine(birsayi.GetType());
            Console.WriteLine(birTarih.GetType());
        }
        static void StringMetotlari()
        {
            string metin = "Hi my name is Slim Shady";

            var result = metin.Length;//metin değişkeninin uzunluğunu verir
            var result2 = metin.Clone();//Clone metotu metni çoğaltır
            metin = "My name is Enes/";

            bool result3 = metin.EndsWith("a"); //metin a ile bitiyor mu?
            bool result4 = metin.StartsWith("My name"); //metin My name ile başlıyor mu?

            var result5 = metin.IndexOf("namee");// indexof metodu metin içerisinde aradığımız karakteri bulamazsa geriye -1 döndürür
            var result6 = metin.IndexOf(" ");//indexof metodu metein içerisinde aradığımız karakteri bulursa geriye karakterin index numarasını döndürür.

            var result7 = metin.LastIndexOf("/");//aradığımız karakterin en son geçtiği index değeri verir
            var result8 = metin.Insert(0, "Hello, ");//eklemek istediğimiz index numarası ve yazıyı eklemek için kullanılır
            var result9 = metin.Substring(3, 4); //3. indexten başlayarak 4 karakterlik veriyi parçalamak için kullanılır
            var result10 = metin.ToLower();//Metin içerisindeki bütün yazıları küçültmek için kullanılır
            var result11 = metin.ToUpper();//Metin içerisindeki bütün yazıları büyültmek için kullanılır
            var result12 = metin.Replace(" ", "-");// aynı ifade de olan metindeki bütün karakterleri değiştirmek için kullanılır
            var result13 = metin.Remove(2, 5);//burda kaçıncı index numarasından başlayıp kaç karakter sileceğini belirtip silmek için kullanılır
            //String sınıfına bir değer ataması yapmazsak varsayılan değeri null olur
            //String referans tiplidir, diğer değişkenler veri tipleri değer tiplidir
            //String nesnedir değiştirilemez, bildirimi yapılan bir string üzerinde bir değişiklik yapılırsa bu değişiklik arka tarafta başka stringin oluşmasına sebep olur

            Console.WriteLine("Metin değişkeninin değerini klonlayıp result2 ye yapıştır: " + result2);
            Console.WriteLine("Metin değişkeni a ile mi bitiyor? " + result3);
            Console.WriteLine("Metin değişkeni My name ile mi başlıyor? " + result4);
            Console.WriteLine("Metin değişkeni içerisinde namee kelimesi var mı? " + result5);
            Console.WriteLine("Metin değişkeninde boşluk var mı? " + result6);
            Console.WriteLine("Metin değişkeninde geçen son / karakteri kaçıncı indexte?  " + result7);
            Console.WriteLine("Metin değişkenine 0. indexten başlayarak Hello, kelimesini ekle " + result8);
            Console.WriteLine("Metin değişkenini 3. indexten başlayarak 4 karakterini al " + result9);
            Console.WriteLine("Metin değişkenindeki karakterleri küçült " + result10);
            Console.WriteLine("Metin değişkenindeki karakterleri büyük harfe çevir " + result11);
            Console.WriteLine("Metin değişkenindeki boşlukları - ile değiştir " + result12);
            Console.WriteLine("Metin değişkenini 2. indexten başlayarak 5 karakter sil  " + result13);
        }

        static void Kiyasla()
        {
            string kelime1 = "Ankara";
            string kelime2 = "İstanbul";
            string kelime3 = "ANKARA";
            string kelime4 = "Ankara";

            Console.WriteLine(kelime1 == kelime2);
            Console.WriteLine(kelime1 != kelime2);
            Console.WriteLine(kelime1 == kelime3);
            Console.WriteLine(kelime1 == kelime4);

            Console.WriteLine("Ankara" == "ANKARA");
            Console.WriteLine("Ankara" != "ANKARA");
        }

        static void Login()
        {
            string trueUser = "enes";
            string truePass = "1234";
            int hak = 3;

            do
            {
                Console.WriteLine("Lütfen kullanıcı adınızı giriniz");
                string userName = Console.ReadLine();
                Console.WriteLine("Lütfen şifrenizi giriniz");
                string password = Console.ReadLine();
                userName = userName.ToLower().Trim();
                password = password.Trim();

                if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
                {
                    hak--;
                    Console.WriteLine("Kullanıcı adı veya şifre boş bırakılamaz!");
                    Console.WriteLine($"Kalan hak: {hak}");
                    continue;
                }
                else if (userName != trueUser)
                {
                    hak--;
                    Console.WriteLine("Kullanıcı adı yanlış");
                    Console.WriteLine($"Kalan hak: {hak}");
                    continue;
                }
                else if (password != truePass)
                {
                    hak--;
                    Console.WriteLine("Şifre Hatalı");
                    Console.WriteLine($"Kalan hak: {hak}");
                    continue;
                }
                else 
                { 
                    Console.WriteLine("Hoşgeldin canım.");
                    break;
                }
            } 
            while (hak > 0);
            if (hak == 0)
            {
                Console.WriteLine("Hesap Kilitlendi");
            }
        }
    }
}
