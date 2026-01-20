//For Döngüsü
/*Console.WriteLine("For Döngüsü");
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
*/
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






Console.Read();