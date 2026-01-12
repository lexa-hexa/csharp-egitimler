
//Değişken Türleri
// int --> tamsayı değerlerini tutmak için kullanılır
// string --> metinsel ifadeler için kullanılır
// bool --> sadece true veya false değerlerini alır
// double --> kesirli sayılar için kullanılır
// char --> char tek bir karakter tutmak için kullanılır ve 'c' gibi tek tırnak içinde yazılır.
// float --> ondalık kesirli sayılar için kullanılır ve belirtirken float temperature = 3.15f; olarak sayı sonunda f olmak zorundadır.
// decimal --> para ve finansal hesaplamalar için kullanılır, hassas küsuratlı sayılar tutar
// long --> çok büyük tam sayılar için kullanılır
// DateTime --> tarih ve saat için kullanılır

// Örnek 1
int age = 25; //Kullanıcının yaşını tutmak için kullanılır. 
string fullName = "Enes"; // Kullanıcının adını tutmak için kullanılır.
bool isEmployed = true; // Kullanıcının çalışıp çalışmadığını belirtmek için kullanılır.

// Örnek 2
double price = 149.99; //Ürün fiyatı için kullanılır
int stockCount = 20; //Ürün stok sayısı için kullanılır
bool isInStock = false; // Stokta olup olmadığının kontrolü için kullanılır

// Double ve Decimal fark örneği 
double a = 1.10;
double b = 2.20;
Console.WriteLine(a + b);

decimal c = 1.10m;
decimal d = 2.20m;
Console.WriteLine(c + d);

