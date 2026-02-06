# 🎓 C# Eğitim ve Öğrenme Deposu (Console Uygulamaları)

Bu depo, **C# öğrenme sürecimde** konuları adım adım ilerleyerek geliştirdiğim **console uygulamalarını** içermektedir. Amaç; C# temellerini **ezbere değil**, arkasındaki **mantığı anlayarak** öğrenmek ve bu temeli ileride **gerçek dünya projelerine** sağlam bir şekilde taşımaktır.

Her klasör, belirli bir konuyu temsil eder ve o konuya ait **örnekler, mini alıştırmalar ve küçük uygulamalar** barındırır. Konular ilerledikçe, örnekler de daha gerçekçi senaryolar içerecek şekilde geliştirilmiştir.

🎯 **Nihai hedefim:** Sağlam bir C# temeli üzerine **Web API**, **veritabanı** ve **full‑stack** projeler geliştirmek.

---

## 📂 Repo Yapısı ve İçerik

### 🔹 Konular

#### 01 – Değişkenler (Variables)

* Temel veri tipleri: `int`, `string`, `bool`, `double`, `char`, `float`, `decimal`, `long`, `DateTime`
* Değişken tanımlama ve kullanım örnekleri
* `double` ve `decimal` arasındaki farklar
* Finansal işlemlerde neden `decimal` tercih edilmesi gerektiği

#### 02 – Veri Tipleri ve Tür Dönüşümleri

* Implicit / Explicit conversion
* `Convert`, `Parse`, `TryParse` kullanımı

#### 03 – Operatörler

* Aritmetik, karşılaştırma ve mantıksal operatörler
* Operatör önceliği

#### 04 – Koşul Yapıları (if / switch)

* Karar mekanizmaları
* Gerçek senaryo örnekleri

#### 05 – Döngüler (for / while / foreach / do‑while)

* Tekrarlayan işlemler
* Döngü kontrol yapıları

#### 06 – Metotlar

* Parametre alan / almayan metotlar
* Geriye değer döndüren metotlar
* Metotlarla kod tekrarını azaltma

#### 07 – Diziler ve Koleksiyonlar

* Array mantığı
* Temel koleksiyon kullanımı

#### 08 – Classes (Nesne Yönelimli Programlama – OOP)

* Class ve Object kavramları
* Constructor (kurucu metot)
* Field ve Method ayrımı
* Gerçek hayat senaryosu: **BankaHesabi** örnek uygulaması

📌 Yeni konular, öğrenme sürecime paralel olarak **düzenli şekilde eklenecektir**.

---

## ▶️ Nasıl Çalıştırılır?

### 🟦 Seçenek 1 – Visual Studio ile

1. `csharp-egitimler.sln` dosyasını açın
2. Çalıştırmak istediğiniz projeyi seçin (örn: `08-Classes`)
3. **Run / Çalıştır**

### 🟦 Seçenek 2 – .NET CLI ile

Repo kök dizininde aşağıdaki komutları çalıştırın:

```bash
dotnet build
dotnet run --project src/01-Variables/Variables/Variables.csproj
```

---

## 💡 Neden Finansal İşlemlerde `decimal` Kullanılır?

* `double` veri tipi ikili (binary) sayı sistemi kullandığı için küçük hassasiyet hatalarına yol açabilir.
* `decimal` veri tipi ise ondalık tabanlıdır ve **finansal hesaplamalar** için tasarlanmıştır.

📌 Bu nedenle aşağıdaki işlemlerde `decimal` kullanımı daha doğru ve güvenlidir:

* Para
* Maaş
* Fiyat
* Vergi

---

## 🗺️ Öğrenme Yol Haritası

* 01 – Değişkenler
* 02 – Veri Tipleri ve Tür Dönüşümleri
* 03 – Operatörler
* 04 – Koşul Yapıları
* 05 – Döngüler
* 06 – Metotlar
* 07 – Diziler ve Koleksiyonlar
* 08 – Classes (OOP)
* 09 – Access Modifiers
* 10 – Exception Handling
* 11 – Mini Console Projeleri

---

## 🚀 Sonraki Aşama

* Web API
* Veritabanı (SQL)
* Full‑Stack uygulamalar

---

## 👤 Hakkımda

**Enes Yerebakan**
Aspiring Backend / Full‑Stack Developer

🔗 GitHub: [https://github.com/lexa-hexa](https://github.com/lexa-hexa)

---

Bu repo, öğrenme sürecimi **şeffaf bir şekilde belgelemek** ve gelişimimi **adım adım göstermek** amacıyla oluşturulmuştur.
