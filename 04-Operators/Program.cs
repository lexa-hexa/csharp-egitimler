//Operatörler (Operators)


//-- Aritmetik Operatörler ( +, -, *, /, %, ++, -- )

using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

int a = 50;
int b = 40;
int c = 30;


int sonuc = a + b;
int sonuc2 =    a - b;
int sonuc3 = a * b;
float sonuc4 = (float)a / (float)b;
int sonuc5 = a % b;
int sonuc6 = a++;
int sonuc7 = b--;

Console.WriteLine("sayi1 + sayi2 = "+ sonuc);
Console.WriteLine("sayi1 - sayi2 = " + sonuc2);
Console.WriteLine("sayi1 * sayi2 = " + sonuc3);
Console.WriteLine("sayi1 / sayi2 = " + sonuc4);
Console.WriteLine("sayi1 % sayi2 = " + sonuc5);
Console.WriteLine("sayi1 ++ sayi2 = " + sonuc6);
Console.WriteLine("sayi1 -- sayi2 = " + sonuc7);

//-- Atama Operatörleri ( =, +=, -=, *=, /=, %= )

Console.WriteLine(a += b);
Console.WriteLine(a = a + b);
Console.WriteLine(a -= b);
Console.WriteLine(a *= b);
Console.WriteLine(a /= b);
Console.WriteLine(a %= b);

//-- İlişkisel Operatörler ( ==, !=, <, >, <=, >=, ?: )

Console.WriteLine(a == b); // a, b ye eşit mi
Console.WriteLine(a !=  b); // a, b ye eşit değil mi
Console.WriteLine(a > b); // a, b den büyük mü 
Console.WriteLine(a < b); // a, b den küçük mü
Console.WriteLine(a <= b); // a, b den küçük veya eşit mi
Console.WriteLine(a >= b); // a, b den büyük veya eşit mi

string sonuc8 = (a == b) ? "a, b ye eşit" : "a, b ye eşit değil";
// ? işareti işlemin sonucunu teyit etmek için 
Console.WriteLine(sonuc8);

//-- Mantıksal Operatörler (&&, ||, !)

// && (and - ve)

// true && true => true
// true && false => false 
// false && false => false

Console.WriteLine((a > b) && (a > c)); //a, b den büyük ve a c den büyükse

// || (or - veya)
Console.WriteLine((a > b) || (a > c)); //a b den büyükse veya a c den büyükse

// !(not - değil)
bool sonuc9 = !( a > b );
Console.WriteLine("sonuc9: " + sonuc9);


/*----- ÖRNEKLER ------*/

// 1- Sayı Pozitif mi negatif mi?
// Alternatif yapılışı daha temiz --> Console.WriteLine(x > 0 ? "Pozitif" : x == 0 ? "Sıfır" : "Negatif");


int x = 10;
Console.WriteLine((x >= 0) ? "Pozitif": "Negatif");

// 2- Çift mi tek mi?
// Alternatif yapılışı daha temiz --> Console.WriteLine(y % 2 == 0 ? "Çift" : "Tek")

int y = 25;
int sonuc10 = (y % 2); 
Console.WriteLine((sonuc10 == 0) ? "Çift": "Tek");

// 3- En büyük sayıyı bul
// Alternatif yapılışı daha temiz --> int enBuyuk = (k > l && k > j) ? k : (l > j ? l : j);

int k = 5;
int l = 6;
int j = 7;

int enBuyuk;

if(k > l && k> j)
{
    enBuyuk = k;
}else if( l > k && l > j ){
    enBuyuk = l;
}
else{
    enBuyuk = j;
}

Console.WriteLine(enBuyuk);

// 4- Not hesaplama (Geçti / Kaldı)

    int not = 45;
Console.WriteLine((not >= 50) ? "Geçti" : "Kaldı");


// 5- Arttır / Azalt

int u = 10;
int v = u++;
int n = ++v;

Console.WriteLine(u);
Console.WriteLine(v);
Console.WriteLine(n);





Console.Read();