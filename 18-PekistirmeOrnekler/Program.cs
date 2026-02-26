using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _18_PekistirmeOrnekler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ogrenciler();
            Console.WriteLine("Merhabalar Enes'in Harikalar diyarına hoş geldin");
            Console.WriteLine("Lütfen yapmak istediğin işlemi seç:");
            Console.WriteLine("\n");
            int islem;
            do
            {
                Console.WriteLine("1 - Çalışan Ekle\n2 - Id ile çalışan bul\n3 - Id ile çalışan sil\n4 - Çalışanları Listele\n5 - Çalışan bilgisi güncelleme\n0 - Çıkış");
                islem = Convert.ToInt32(Console.ReadLine());
                switch (islem)
                {
                    case 1:
                        Personels();
                        break;
                    case 2:
                        FindEmployee();
                        break;
                    case 3:
                        DeleteEmployee();
                        break;
                    case 4:
                        ListEmployee();
                        break;
                    case 5:
                        UpdateEmployee();
                        break;
                    case 0:
                        Console.WriteLine("Çıkış yapılıyor");
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim, Lütfen doğru seçim yaptığınızdan emin olun!");
                        break;
                }
            } while (islem != 0);

            Console.Read();
        }
        class Students
        {
            public int Id { get; set; }
            public string Adi { get; set; }
            public string Soyadi { get; set; }
            public string Bolum { get; set; }
        }
        static void Ogrenciler()
        {
            List<Students> students = new List<Students>();
            students.Add(new Students { Id = 1, Adi = "Enes", Soyadi = "Yerebakan", Bolum = "Yazılım Geliştirme" });
            students.Add(new Students { Id = 2, Adi = "Polat", Soyadi = "Alemdar", Bolum = "Proje Geliştirme" });
            students.Add(new Students { Id = 3, Adi = "Memati", Soyadi = "Baş", Bolum = "Ürün Geliştirme" });

            Console.WriteLine("Aradığınız öğrencinin id sini giriniz:");
            int id = int.Parse(Console.ReadLine());
            bool bulunduMu = false;


            foreach (Students student in students)
            {
                if (student.Id == id)
                {
                    bulunduMu = true;
                    Console.WriteLine($"Id: {student.Id} | Adı: {student.Adi} | Soyadı: {student.Soyadi} | Bölümü: {student.Bolum}");
                    break;
                }
            }
            if (!bulunduMu)
            {
                Console.WriteLine("Kullanıcı bulunmamaktadır");
            }
            /*
            👉 List = sıra
            👉 Arama = dolaşma
            👉 Flag = sonuç bilgisi
            👉 break = erken durdurma
            👉 Döngü sonrası = karar
            👉 Object = veri kabı

            Bu 6 madde collections’ın temelidir.
            */

            //Soru: Eğer listede 1000 öğrenci varsa, Id ile arama yaparken neden listeyi dolaşmak zorundayız?
            //Cevap: 
            /*
                 Listede Id ile arama yaparken listeyi dolaşmak zorundayız çünkü:

                👉 List elemanların Id’ye göre nerede olduğunu bilmez
                👉 Id’ye göre indeksleme yapmaz
                👉 Sadece sırayla tutar

                Yani programın elinde şu bilgi yok:

                Id 74 → index 73

                Bu yüzden tek yöntem:

                👉 Baştan sona bakmak

                Bu algoritmaya:

                Linear search (doğrusal arama) denir.
             */

            //Soru: Eğer Id ile hızlı arama yapmak istiyorsak neden List yerine Dictionary kullanırız?
            //Cevap: Dictionary’de her veri bir key ile eşleştiği için arama yapılırken listeyi dolaşmaya gerek kalmaz, key üzerinden doğrudan ilgili değere ulaşılır ve bu nedenle List’e göre daha hızlıdır.

            //👉 List = aramak için dolaşılır
            //👉 Dictionary = anahtar ile direkt bulunur

            // ================= LIST vs DICTIONARY SEBEPLER =================

            // 1️ - Sıralı veri ihtiyacı
            // List verileri eklenme sırasına göre tutar.
            // UI’de listeleme, blog yazıları, sipariş geçmişi gibi durumlarda sıralama önemlidir.
            // Dictionary sıralı değildir, bu yüzden sıralı gösterim gereken yerde List kullanılır.

            // 2️ - Key zorunluluğu
            // Dictionary kullanmak için her veri için benzersiz bir key gerekir.
            // Ancak bazı senaryolarda key yoktur veya önemli değildir.
            // Bu durumlarda List daha uygun bir veri yapısıdır.

            // 3️ - Memory kullanımı
            // Dictionary hash table yapısı kullandığı için List’e göre daha fazla memory tüketir.
            // Basit veri saklama işlemlerinde List daha hafiftir.

            // 4️ - Duplicate veri ihtiyacı
            // Dictionary’de key benzersiz olmak zorundadır.
            // Aynı key tekrar eklenemez.
            // Ancak List duplicate veri tutabilir (aynı öğrenci, aynı ürün vb).

            // 5️ - Basitlik ve kullanım kolaylığı
            // List daha basit bir veri yapısıdır.
            // Iterasyon (foreach), veri ekleme ve saklama işlemleri kolaydır.
            // Bu yüzden genel veri saklama senaryolarında List tercih edilir.

            // ================= MENTAL MODEL =================

            // List = sıralı veri koleksiyonu
            // Dictionary = key ile hızlı erişim (lookup)


            //Soru: Öğrenci sisteminde hangi işlem için Dictionary kullanmak daha mantıklı olur ve neden?
        }
        class Employee
        {
            public int Id { get; set; }
            public string Adi { get; set; }
            public string Soyadi { get; set; }
            public string Departman { get; set; }
            public decimal Maas { get; set; }
        }
        static List<Employee> employees = new List<Employee>();
        static Dictionary<int, Employee> employeeById = new Dictionary<int, Employee>();
        static void Personels()
        {
            Console.WriteLine("Lütfen Id numarası giriniz");
            int id = int.Parse(Console.ReadLine());



            if (employeeById.ContainsKey(id))
            {
                Console.WriteLine("Bu kullanıcı kayıtlı!");
            }
            else
            {
                Employee emp = new Employee();
                emp.Id = id;
                Console.WriteLine("Yeni kullanıcı oluşturuluyor lütfen bilgileri eksiksiz giriniz.");
                Console.Write("Ad: ");
                emp.Adi = Console.ReadLine();
                Console.Write("Soyad: ");
                emp.Soyadi = Console.ReadLine();
                Console.Write("Departman: ");
                emp.Departman = Console.ReadLine();
                Console.Write("Maaş bilgisi: ");
                emp.Maas = decimal.Parse(Console.ReadLine());

                employees.Add(emp);
                employeeById.Add(id, emp);
                Console.WriteLine("Yeni kullanıcı eklendi!");
            }

        }
        static void FindEmployee()
        {
            Console.Write("Merhaba, lütfen aradığınız çalışan id sini girer misiniz: ");
            int id = int.Parse(Console.ReadLine());

            if (employeeById.ContainsKey(id))
            {
                Console.WriteLine("Personelin dictionary ile aranması sonucu");
                Employee emp = employeeById[id];
                Console.WriteLine($"Id: {emp.Id} | Ad: {emp.Adi} | Soyad: {emp.Soyadi} | Departman: {emp.Departman} | Maaş: {emp.Maas}");
            }
            else { Console.WriteLine("Böyle bir kullanıcı bulunmamaktadır"); }

            Console.WriteLine("Liste ile arama");
            bool bulunduMu = false;
            foreach (Employee n in employees)
            {
                if (n.Id == id)
                {
                    bulunduMu = true;
                    Console.WriteLine($"Id: {n.Id} | Ad: {n.Adi} | Soyad: {n.Soyadi} | Departman: {n.Departman} | Maaş: {n.Maas}");
                    break;
                }
            }
            if (!bulunduMu)
            {
                Console.WriteLine("Liste'de kişi bulunamadı");
            }


        }
        static void DeleteEmployee()
        {
            Console.Write("Merhabalar, lütfen silmek istediğiniz kişinin id numarasını giriniz:");
            int id = int.Parse(Console.ReadLine());

            if (employeeById.ContainsKey(id))
            {
                Employee emp = employeeById[id];
                Console.WriteLine("Personelin dictionaryden silinmesi");
                employeeById.Remove(id);
                employees.Remove(emp);
                Console.WriteLine($"Silindi: {emp.Id} {emp.Adi} {emp.Soyadi} {emp.Departman} {emp.Maas}");
            }

            //Dictionary: Id → objeyi bulur
            //List: objeyi veya indexi kullanarak siler
            //Biz: Id ile objeyi dictionary’den bulup, objeyi listeden siliyoruz

            else { Console.WriteLine("Böyle bir kullanıcı maalesef veri tabanımızda bulunmuyor"); }
        }
        static void ListEmployee()
        {
            if(employees.Count == 0)
            {
                Console.WriteLine("Kayıt yok");
            }
            else
            {
                foreach (var user in employees)
                {
                    Console.WriteLine($"Id: {user.Id} | Adı: {user.Adi} | Soyadı: {user.Soyadi} | Departman: {user.Departman} | Maaş: {user.Maas}");
                }
            }
        }
        static void UpdateEmployee()
        {
            Console.WriteLine("Lütfen bilgilerini güncellemek istediğiniz kişinin id numarasını giriniz.");
            int id = int.Parse(Console.ReadLine());

            if (employeeById.ContainsKey(id))
            {
                Employee emp = employeeById[id];
                bool devam = true;
                do
                {
                    Console.WriteLine("Kişinin hangi bilgisini güncellemek istiyorsunuz?");
                    Console.WriteLine("1 - Ad\n2 - Soyad\n3 - Departman\n4 - Maaş\n0 - Çıkış");
                    int islem = int.Parse(Console.ReadLine());
                    switch (islem)
                    {
                        case 0:
                            Console.WriteLine("Çıkılıyor..");
                            devam = false;
                            break;
                        case 1:
                            Console.Write("Yeni ad:");
                            string ad = Console.ReadLine();
                            emp.Adi = ad;
                            Console.WriteLine("Güncelleme yapıldı!");
                            break;
                        case 2:
                            Console.Write("Yeni Soyad:");
                            string soyad = Console.ReadLine();
                            emp.Soyadi = soyad;
                            Console.WriteLine("Güncelleme yapıldı!");
                            break;
                        case 3:
                            Console.Write("Yeni Departman:");
                            string departman = Console.ReadLine();
                            emp.Departman = departman;
                            Console.WriteLine("Güncelleme yapıldı!");
                            break;
                        case 4:
                            Console.Write("Yeni Maaş:");
                            decimal maas = decimal.Parse(Console.ReadLine());
                            emp.Maas = maas;
                            Console.WriteLine("Güncelleme yapıldı!");
                            break;
                        default:
                            Console.WriteLine("Hata oluştu!");
                            break;
                    }
                    


                } while (devam);
                
            }
            else { Console.WriteLine("Veritabanında böyle biri yok"); }

        }
    }
}
