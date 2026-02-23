using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_PekistirmeOrnekler
{
    //2D Nokta Koordinat Sistemi
    /*  
        🎯 Senaryomuz
        Harita / oyun / çizim uygulaması geliştiriyorsun
        Her noktanın x ve y koordinatı olmak zorunda
    */
    interface Inokta
    {
        int X { get; set; }
        int Y { get; set; }
    }
    class Nokta2D : Inokta
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Inokta n = new Nokta2D();
            n.X = 5;
            n.Y = 10;
            Console.WriteLine(n.X + n.Y);

            Console.Read();
        }
    }
}
