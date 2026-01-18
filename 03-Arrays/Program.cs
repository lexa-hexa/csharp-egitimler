//Dizi oluşturma
int[] sayi; //Veri tipini belirtikten sonra köşeli parantez koyup dizi adını vererek dizimizi oluşturuyoruz.
//Dizilerde indis denilen yapı vardır ve bu elemanları 0 dan başlatır
string[] personelName = new string[5];

personelName[0] = "Enes";
personelName[1] = "Uras";
personelName[2] = "Aden";
personelName[3] = "Duman";
personelName[4] = "Kerem";
//personelName[5] = "Alya";
//Dizilerde tanımlanan değer dışına çıkıldığında hata verir 
personelName[2] = "Zafer";
//Dizilerde değişkenler gibi kodun üst satırında farklı bir değer alıp bir noktadan sonra değer değişebilir

int[] ogrenciler = { 100, 200, 300, 400, 500 }; // Bu diğer bir dizi oluşturma yöntemi oluyor.

//Diğer Dizi Türleri
// 2 boyutlu dizi
int[,] arr2Boyut; // 2 Boyutlu dizi

int[,] ikiliSayi = new int[3,2] { { 1,2 }, {3, 4}, {5, 6}};

Console.WriteLine(ikiliSayi[0,0] + "\t");
Console.WriteLine(ikiliSayi[0, 1] + "\t");
Console.WriteLine(ikiliSayi[1, 0] + "\t");
Console.WriteLine(ikiliSayi[1, 1] + "\t");
Console.WriteLine(ikiliSayi[2, 0] + "\t");
Console.WriteLine(ikiliSayi[2, 1] + "\t");

// 3 boutlu dizi
int[,,] arr3Boyut;

int[,,] ucluSayi = new int[1, 2, 3] { { { 1, 2, 3 }, { 3, 4, 5 } } };

// 4 boyutlu dizi
//int[,,,] arr4Boyut;

//Örnek 1
// decimal sonunda m koymak gerekir yoksa c# bunu double olarak sanar
int[] ogrenciNotlari = new int[] { 55, 45, 95, 27, 49 };
decimal[] urunFiyatList = new decimal[] { 199.99m , 45.90m , 5999.99m };
double[] sicaklikDerece = new double[] { 20.34, 19.54, 1.05 };

int toplam = (ogrenciNotlari[0] + ogrenciNotlari[1] + ogrenciNotlari[2] + ogrenciNotlari[3]);


Console.WriteLine(toplam);
Console.Read();