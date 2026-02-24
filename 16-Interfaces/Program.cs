using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Interfaces
{
    interface OrnekArayuz
    {
        //interface içerisinde property de public otomatik gelir 
        int MyProperty { get; set; }
    }
    interface Idemo
    {
        void Goster();//Interface lerde sadece metot imzaları yer alır, metotlar bu interface den miras alan class larda kullanılır.
    }
    interface Inokta
    {
        //Özgenlerin imzaları
        int x { get; set; }
        int y { get; set; }
    }
    //Inokta arayüzünü implement eden sınıfımız
    class Nokta : Inokta
    {
        //Alanlar fields
        private int _x {  get; set; }
        private int _y { get; set; }

        public int x 
        { 
            get { return _x; } 
            set { _x = value; } 
        }
        public int y
        {
            get { return _y; }
            set { _y = value; }
        }
    }
    interface icerebilecekleri : Idemo
    {
        //Bir interface in içerebileceği özellikler 
        //public int MyProperty { get; set; } bir interface içerisine prop tab tab ile property eklersek başındaki public ifadesini kaldırmak zorundayız çünkü interfaceler erişim belirteci almaz daima public tir zaten
        int Sayi { get; set; } //Interface ler erişim belirteci olmadan propertyleri barındırabilir
        // static int Sayi2 {get; set;}
        void MesajVer(); //Interface ler metot imzalarını barındırabilir
        //string metin; interface ler içerisinde değişken kullanılamaz
        //Interface ler class lardaki kurucu metotları da kullanamaz
        int CikarmaYap(int sayi1, int sayi2); //Interface ler parametreli metot imzası alabilir
        /*int CikarmaYap(int sayi1, int sayi2)
        {
            return sayi1 - sayi2; //Interface ler içerisinde metotların yapacağı işler tanımlanmaz
        }*/
    }
    class ArayuzKullanimi : icerebilecekleri
    {
        public int Sayi { get; set; }

        public int CikarmaYap(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        public void Goster()
        {
            Console.WriteLine("interface de imzası tanımlanan metodun yapacağı iş class da belirlenir");
        }

        public void MesajVer()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    interface ISinifGereksinimleri
    {
        int Id { get; set; }
        int Name { get; set; }
        int Description { get; set; }
        DateTime CreateAt { get; set; }
        DateTime UpdateAt { get; set; }
    }
    interface IVeritabaniIslemleri
    {
        void Add();
        void Update();
        void Delete();
        void Get();
        void GetAll();
    }
    class Kategori : ISinifGereksinimleri, IVeritabaniIslemleri
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
    class Urun : ISinifGereksinimleri
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public decimal Price { get; set; }
    }
    class Marka : ISinifGereksinimleri
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
