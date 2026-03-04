# Product Management App (ADO.NET)

Bu proje, **C# Windows Forms ve ADO.NET** kullanılarak geliştirilmiş basit bir **Ürün Yönetim Uygulamasıdır**.
Uygulama SQL Server veritabanına bağlanarak ürünler üzerinde **CRUD (Create, Read, Update, Delete)** işlemlerini gerçekleştirir.

## 🚀 Özellikler

* SQL Server veritabanı bağlantısı
* Ürün listeleme
* Yeni ürün ekleme
* Ürün güncelleme
* Ürün silme
* DataGridView ile verileri görüntüleme

## 🧱 Kullanılan Teknolojiler

* C#
* Windows Forms
* ADO.NET
* SQL Server
* Visual Studio

## 🗄 Veritabanı Yapısı

Kullanılan tablo örneği:

```sql
CREATE TABLE Products
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UrunAdi NVARCHAR(100),
    UrunFiyati DECIMAL(18,2),
    StokMiktari INT
);
```

## ⚙️ Bağlantı

ADO.NET ile SQL Server bağlantısı aşağıdaki connection string ile sağlanmaktadır:

```csharp
SqlConnection connection = new SqlConnection(
@"server=.; initial catalog=UrunYonetimi; Integrated security=True");
```

## 📚 Öğrenme Amacı

Bu proje aşağıdaki konuları pekiştirmek amacıyla geliştirilmiştir:

* ADO.NET bağlantısı
* SqlCommand kullanımı
* SQL CRUD işlemleri
* Windows Forms ile veritabanı işlemleri


## 📷 Application Screenshots

| Add Product | Update Product |
|-------------|---------------|
| ![](images/add-product.png) | ![](images/update-product.png) |

| Delete Confirmation | Delete Result |
|---------------------|--------------|
| ![](images/delete-confirm.png) | ![](images/delete-result.png) |
