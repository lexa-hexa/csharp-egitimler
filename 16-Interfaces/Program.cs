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
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
