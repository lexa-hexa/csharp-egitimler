using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ornek1();
            Ornek2();
            Ornek3();
            Ornek4();
            Ornek5();
            Ornek6();
            Ornek7();
            Ornek8();
            Ornek9();
            ListKullanimi();

            Console.Read();
        }
        static void Ornek1()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(12);
            arrayList.Add(14);
            arrayList.Add(16);

            foreach (var item in arrayList) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(arrayList[1]);
        }
        static void Ornek2()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("İzmir");
            arrayList.Add("Ankara");
            arrayList.Add("İstanbul");
            Console.WriteLine("Sıralanmamış Liste");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
            Console.WriteLine("Sıralanmış Liste");
            arrayList.Sort();//A dan Z ye sıralama için kullanıyoruz
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
            Console.WriteLine("Ters Sıralanmış Liste");
            arrayList.Reverse();//Z den A ya sıralama için kullanıyoruz
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }
        static void Ornek3()
        {
            //Koleksiyonlara farklı veri tiplerinden değerler atama
            int tamSayi = 20;
            double dabil = 10.8;
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Başkent Ankara");
            arrayList.Add(tamSayi);
            arrayList.Add(dabil);

            for (int i = 0; i < arrayList.Count; i++) 
            {
                Console.WriteLine(arrayList[i]);
            }


        }
        static void Ornek4()
        {
            StringCollection sc = new StringCollection();
            sc.Add("Ankara");
            sc.Add("İstanbul");
            sc.Add("İzmir");
            foreach (var item in sc)
            {
                Console.WriteLine(item);
            }
        }
        static void Ornek5()
        {
            StringDictionary stringDictionary = new StringDictionary();
            stringDictionary.Add("06", "Ankara");
            stringDictionary.Add("34", "İstanbul");
            stringDictionary.Add("35", "İzmir");
            Console.WriteLine(stringDictionary["06"]);
            foreach (var item in stringDictionary.Values)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stringDictionary.Keys)
            {
                Console.WriteLine(item);
            }
        }
        static void Ornek6()
        {
            Stack stack = new Stack();//Stack sınıfı programlamada LIFO (last in first out) son giren ilk çıkar diye bilinen önemli bir yapıdır.
            stack.Push("Ankara");
            stack.Push("İstanbul");
            stack.Push("İzmir");

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());//Stack in üstünden bir öğe çekmek için pop metodu kullanılır
            }
        }
        static void Ornek7() 
        {
            //Queue sınıfı programlamada FIFO (First in first out, ilk giren ilk çıkar) diye bilinen bir yapısıdır.
            Queue queue = new Queue();
            queue.Enqueue("Ankara");
            queue.Enqueue("İstanbul");
            queue.Enqueue("İzmir");

            while(queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
        static void Ornek8()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(06, "Ankara");
            hashtable.Add(34, "İstanbul");
            hashtable.Add(35, "İzmir");
            Console.WriteLine("Anahtarlar");
            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Değerler");
            foreach (var item in hashtable.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Arama yapmak için değeri girin: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(hashtable[n]);
        }
        static void Ornek9()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("book","Kitap");
            keyValuePairs.Add("table", "masa");
            keyValuePairs.Add("computer", "bilgisayar");
            keyValuePairs.Add("laptop", "dizüstü");
            keyValuePairs.Add("tv", "televizyon");

            Console.WriteLine(keyValuePairs["table"]);


            Dictionary<int, string> keyValues = new Dictionary<int, string>();
            keyValues.Add(01, "Adana");
            keyValues.Add(06, "Ankara");
            keyValues.Add(34, "İstanbul");
            keyValues.Add(35, "İzmir");
            Console.WriteLine(keyValues[35]);

            foreach (var item in keyValuePairs) 
            {
                Console.WriteLine($"Anahtar: {item.Key} | Değer: {item.Value}");
            }
            Console.WriteLine(keyValuePairs.ContainsKey("gozluk"));
            Console.WriteLine(keyValuePairs.ContainsKey("table"));
        }
        class User
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        static void ListKullanimi()
        { 
            List<string> sehirler = new List<string>();
            sehirler.Add("İstanbul");
            sehirler.Add("Ankara");
            sehirler.Add("İzmir");
            Console.WriteLine(sehirler.Contains("Adana"));
            foreach (var item in sehirler) 
            { 
                Console.WriteLine(item); 
            }
            List<User> users = new List<User>();
            users.Add(new User { Id = 1, FirstName = "Enes", LastName = "Yerebakan"});
            users.Add(new User { Id = 2, FirstName = "Polat", LastName = "Alemdar" });
            users.Add(new User { Id = 3, FirstName = "Memati", LastName = "Baş" });

            List<User> kullanicilar = new List<User>()
            {
                new User { Id = 1, FirstName = "Enes", LastName = "Yerebakan" },
                new User { Id = 2, FirstName = "Polat", LastName = "Alemdar" },
                new User { Id = 3, FirstName = "Memati", LastName = "Baş" }
            };
            var yeniKullanici = new User
            {
                Id = 4, FirstName = "Abdulhey", LastName = "Gezer"
            };
            Console.WriteLine(kullanicilar.Contains(yeniKullanici));
            kullanicilar.Add(yeniKullanici);
            kullanicilar.AddRange(new User[2]
            {
                new User { Id = 1, FirstName = "Enes", LastName = "Yerebakan" },
                new User { Id = 2, FirstName = "Polat", LastName = "Alemdar" },
            });
            kullanicilar.AddRange(users);
            Console.WriteLine(kullanicilar.Contains(yeniKullanici));

            var index = kullanicilar.IndexOf(yeniKullanici);
            Console.WriteLine("yeniKullanici index numarası: " + index);

            kullanicilar.Add(yeniKullanici);
            var sonindex = kullanicilar.LastIndexOf(yeniKullanici);
            Console.WriteLine("yeniKullanici son index numarası: " + sonindex);

            kullanicilar.Insert(1, yeniKullanici);
            kullanicilar.Remove(yeniKullanici);//Listeden eleman silmek için kullanılır
            //Insert ve Add farkı
            //Add listenin sonuna kullanıcı eklemesi yapıyor 
            //Insert biz başta nereye atamak istediğimizi belirtiyoruz

            foreach (var item in kullanicilar)
            {
                Console.WriteLine("Id: "+ item.Id + " Adı: " + item.FirstName);
            }

            var count = kullanicilar.Count;//kullanicilar listesindeki eleman sayısını göstermek için count kullanılır
            Console.WriteLine($"kullanicilar listesindeki eleman sayısı {count} adettir.");
        }
    }
}
