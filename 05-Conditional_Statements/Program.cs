// Koşul Yapıları ( Conditional Statements )

using System.ComponentModel;

int sayi = -10;

if (sayi > 0) // Eğer sayı değişkeninin değeri 0 dan büyükse 
{ 
    Console.WriteLine("Sayı pozitiftir");
}
else if(sayi == 0)
{
    Console.WriteLine("Sayı sıfırdır");
}
else
{
    Console.WriteLine("Sayı negatiftir");
}

//Kullanıcı Giriş Uygulaması
Console.WriteLine("Kullanıcı Adınızı Giriniz");
string kullaniciAdi = Console.ReadLine(); //Console.Readline() metodu ekranda girilen değeri yakalar ve kullaniciAdi değişkenine atar
Console.WriteLine("Şifrenizi Giriniz");
string sifre = Console.ReadLine();

string veriTabanindakiKullaniciAdi = "admin";
string veriTabanindakiSifre = "123456";

if (kullaniciAdi == veriTabanindakiKullaniciAdi && sifre == veriTabanindakiSifre) 
{
    Console.WriteLine("Kullanıcı Giriş Yaptı");
}
else
{
    Console.WriteLine("Kullanıcı adı veya şifre hatalı");
}

//Yaşına göre ehliyet alabiliyor musun?
Console.WriteLine("Yaşınızı giriniz");
int yas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Öğrenim durumunuz nedir?");
string ogrenim = Console.ReadLine();
if (yas >= 18)
{
    // Tek satırlık kodlarda {} bu tagı kullanmaya gerek yoktur yan yana olduğu gibi yazabiliriz ama birden fazla satırlı ise kesinlikle kullanmak gereklidir
    if (ogrenim == "lise" || ogrenim == "üniversite") Console.WriteLine("Ehliyet Alabilirsiniz.");
    else Console.WriteLine("Öğrenim durumunuz ehliyet için yeterli değil");
}
else Console.WriteLine("Ehliyet için yaşınız tutmuyor");

//Yaşına göre hangi öğretimdesin Uygulaması
Console.WriteLine("Lütfen yaşınızı giriniz");
int kullaniciYas = Convert.ToInt32(Console.ReadLine()); //Console.ReadLine() metodu ekrandan aldığı veriyi string veri tipinde döndürür, convert metoduyla sayısal string veriyi int e çevirebiliriz.
string[] kullaniciOgrenim = {"ilkokul", "ortaokul", "lise", "üniversite", "yükseklisans"};

if (kullaniciYas > 5 && kullaniciYas < 10)
{
    Console.WriteLine(kullaniciOgrenim[0]);
}
else if (kullaniciYas >= 10 && kullaniciYas < 15)
{
    Console.WriteLine(kullaniciOgrenim[1]);
}
else if (kullaniciYas >= 15 && kullaniciYas <= 18)
{
    Console.WriteLine(kullaniciOgrenim[2]);
}
else if (kullaniciYas >= 18 && kullaniciYas <= 22)
{
    Console.WriteLine(kullaniciOgrenim[3]);
}
else
{ 
    Console.WriteLine(kullaniciOgrenim[4]); 
};
Console.WriteLine(string.Join(", ", kullaniciOgrenim));


Console.Read();