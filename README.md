# 🎓 C# Eğitim ve Öğrenme Deposu (Console Uygulamaları)

Bu depo, **C# öğrenme sürecimde** konu konu ilerleyerek geliştirdiğim **console uygulamalarını** içermektedir. Amaç; C# temellerini ezbere değil, **mantığını anlayarak** öğrenmek ve bu temeli ileride **gerçek dünya projelerine** taşımaktır.

Her klasör, belirli bir konuyu temsil eder ve o konuya ait **örnekler, mini alıştırmalar ve küçük uygulamalar** barındırır.

> 🎯 Nihai hedefim: Sağlam bir C# temeli üzerine **Web API, veritabanı ve full‑stack projeler** geliştirmek.

---

## 📂 Repo Yapısı ve İçerik

### 🔹 Konular

**01 – Değişkenler (Variables)**
- Veri tipleri:
  - `int`, `string`, `bool`, `double`, `char`, `float`, `decimal`, `long`, `DateTime`
- Değişken tanımlama ve kullanım örnekleri
- `double` ve `decimal` arasındaki farklar
- Finansal işlemlerde neden `decimal` tercih edilmesi gerektiği

> 📌 Yeni konular, öğrenme sürecime paralel olarak düzenli şekilde eklenecektir.

---

## ▶️ Nasıl Çalıştırılır?

### 🟦 Seçenek 1 – Visual Studio ile
1. `csharp-egitimler.sln` dosyasını açın
2. Çalıştırmak istediğiniz projeyi seçin (örn: **01-Variables**)
3. **Run / Çalıştır**

### 🟦 Seçenek 2 – .NET CLI ile
Repo kök dizininde aşağıdaki komutları çalıştırın:

```bash
dotnet build
dotnet run --project src/01-Variables/Variables/Variables.csproj
```

---

## 💡 Neden Finansal İşlemlerde `decimal` Kullanılır?

- `double` veri tipi, **ikili (binary) sayı sistemi** kullandığı için küçük hassasiyet hatalarına yol açabilir.
- `decimal` veri tipi ise **ondalık tabanlıdır** ve finansal hesaplamalar için tasarlanmıştır.

📌 Bu nedenle;
- Para
- Maaş
- Fiyat
- Vergi

Gibi işlemlerde **`decimal` kullanımı daha doğru ve güvenlidir**.

---

## 🗺️ Öğrenme Yol Haritası

- 01 – Değişkenler
- 02 – Veri Tipleri ve Tür Dönüşümleri
- 03 – Operatörler
- 04 – Koşul Yapıları (`if / switch`)
- 05 – Döngüler (`for / while / foreach / do-while`)
- 06 – Metotlar
- 07 – Diziler ve Koleksiyonlar
- 08 – Nesne Yönelimli Programlama (OOP)
- 09 – Hata Yönetimi (Exception Handling)
- 10 – Mini Console Projeleri

### 🚀 Sonraki Aşama
- Web API
- Veritabanı (SQL)
- Full‑Stack uygulamalar

---

## 👤 Hakkımda

**Enes Yerebakan**  
Aspiring Backend / Full‑Stack Developer

🔗 GitHub: https://github.com/lexa-hexa

> Bu repo, öğrenme sürecimi şeffaf bir şekilde belgelemek ve gelişimimi adım adım göstermek amacıyla oluşturulmuştur.

