//For Döngüsü
Console.WriteLine("For Döngüsü");
int toplam = 0;
int length = 10;
for (int i = 0; i < length; i++)
{
    toplam += i;
    Console.WriteLine("i değişkeninin değeri {0} toplamın değeri {1}", i, toplam);
}
Console.WriteLine("Toplam: " + toplam);

//For döngüsü örnek proje
//Kullanıcıdan alınan yazıya kadar olan çift sayılar ekrana yazdırma
int son = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < son; i++)
{

    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

// Kullanıcıdan alınan değere kadar olan çift sayıların toplamını yazdıran döngü
int k_sayi = Convert.ToInt32(Console.ReadLine());
int k_toplam = 0;
for (int i = 0;i < k_sayi; i +=2)
{
    k_toplam += i;       
}
Console.WriteLine("Çift sayıların toplamı: " + toplam);

//While Döngüsü
Console.WriteLine("While Döngüsü");
int i = 0;
while (i <= 5)
{
    Console.WriteLine("While Sayı {0}", i); // Toplamın değerini ekrana yazdırıyoruz
    i++; // Toplam sayısını arttırıyoruz ki sonsuz döngüye girmesin program
}

//Kullanıcıdan pozitif değer alınca biten ama negatif alınca uyarı veren döngü
int k_deger = Convert.ToInt32(Console.ReadLine());
while (k_deger <0)
{
   Console.WriteLine("Negatif değer girdiniz lütfen pozitif değer giriniz!");
    k_deger = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Başarıyla giriş yapıldı!");


//Do While Döngüsü
Console.WriteLine("Do - While Döngüsü");
int do_toplam = 3;

do
{
    Console.WriteLine("Do While Sayı {0}", do_toplam);
    do_toplam++;
} while ( do_toplam < 10 );

//Basit hesaplama 

int secim = 0;
int sayi1 = 0;
int sayi2 = 0;
int hesapIslem = 0;
do
{
    Console.WriteLine("Yapmak istediğiniz işlem nedir?");
    Console.WriteLine("1 - Toplama");
    Console.WriteLine("2 - Çıkartma");
    Console.WriteLine("3 - Bölme");
    Console.WriteLine("4 - Çarpma");
    Console.WriteLine("5 - Çıkış");

    secim = Convert.ToInt32(Console.ReadLine());

    if( secim == 1)
    {
        Console.WriteLine("Toplamak istediğiniz değerleri giriniz.");
        sayi1 = Convert.ToInt32(Console.ReadLine());
        sayi2 = Convert.ToInt32(Console.ReadLine());

        hesapIslem = sayi1 + sayi2;
        Console.WriteLine("Toplama sonucu: " + hesapIslem);
    }
    else if( secim == 2)
    {
        Console.WriteLine("Çıkartmak istediğiniz değerleri giriniz.");
        sayi1 = Convert.ToInt32(Console.ReadLine());
        sayi2 = Convert.ToInt32(Console.ReadLine());

        hesapIslem = sayi1 - sayi2;
        Console.WriteLine("Çıkartma sonucu: " + hesapIslem);
    }
    else if(secim == 3)
    {
        Console.WriteLine("Bölmek istediğiniz değerleri giriniz.");
        sayi1 = Convert.ToInt32(Console.ReadLine());
        sayi2 = Convert.ToInt32(Console.ReadLine());

        hesapIslem = sayi1 / sayi2;
        Console.WriteLine("Bölme sonucu: " + hesapIslem);
    }
    else if(secim == 4)
    {
        Console.WriteLine("Çarpmak istediğiniz değerleri giriniz.");
        sayi1 = Convert.ToInt32(Console.ReadLine());
        sayi2 = Convert.ToInt32(Console.ReadLine());

        if (sayi2 == 0)
        {
            Console.WriteLine("Bir sayı 0'a bölünemez!");
        }
        else
        {
            hesapIslem = sayi1 / sayi2;
            Console.WriteLine("Bölme sonucu: " + hesapIslem);
        }
    }
    else if (secim == 5)
    {
        Console.WriteLine("Çıkış yapılıyor...");
    }
    else
    {
        Console.WriteLine("Hatalı sayı girdiniz!");
        
    }

} while (secim != 5);
Console.WriteLine("Çıkış yapıldı.");

//Foreach Döngüsü
//Bu döngü genelde dizilerde kullanılır
Console.WriteLine("Foreach Döngüsü");

int[] ogrenciler = {100, 200, 300, 400, 500 };
string[] isimler = { "Enes", "Ahmet", "Tamer" };
// var değişkeni otomatik veri tipini belirlemede yardımcı olur
foreach (var item in isimler)
{
    Console.WriteLine("Öğrenci Adı: " + item);
}
foreach (var ogrenciNo in ogrenciler)
{
    Console.WriteLine("Öğrenci Numarası: " + ogrenciNo);
}
//Ürün durumu sistemi 
int[] fiyatlar = {120, 75, 340, 50, 90, 0, -50};

foreach (var item in fiyatlar)
{
    if (item < 100 && item > 0)
    {
        Console.WriteLine("Fiyat: " + item + " -> Geçersiz Ürün");
    }
    else if(item <= 0)
    {
        Console.WriteLine("Fiyat: " + item + " -> Uygun Ürün");
    }
    else
    {
        Console.WriteLine("Fiyat: " + item + " -> Pahalı Ürün");
    }

//İç İçe For Döngüsü
Console.WriteLine("İç İçe For Döngüsü");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("i değişkeninin değeri {0}", i);
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("\t j değişkeninin değeri {0}", j);
    }
}

//Çarpım Tablosu Yazdırma
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("{0}'larla Çarpım", i);
    for(int j = 1;j <= 5; j++) 
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
}
}

int[] ogrenciler = { 100, 200, 300, 400, 500 };
string[] isimler = { "Enes", "Ahmet", "Tamer" };
Console.WriteLine("İç İçe Foreach Döngüsü");
foreach (var isim in isimler)
{
    Console.WriteLine("Öğrenci Adı: " + isim);
    foreach (var ogrenciNo in ogrenciler)
    {
        Console.WriteLine("   Öğrenci No: " + ogrenciNo);
    }
}

//Sınıf ayrımı
//(Array of arrays)jagged array
string[] urunGrubu = { "Meyveler", "Sebzeler", "İçecekler" };
string[][] urunler =
{
    new string[] {"Elma", "Armut", "Çilek", "Muz" },
    new string[] { "Domates", "Salatalık", "Biber" },
    new string[] { "Su", "Kola", "Enerji İçeceği", "Bira" }
};
int index = 0;
foreach (var grup in urunGrubu)
{
    Console.WriteLine(grup + ": ");
    foreach (var urun in urunler[index])
    {
        Console.WriteLine("\t" + urun);
    }
    index++;
}


Console.Read();