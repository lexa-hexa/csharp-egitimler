using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _09_Access_Modifiers //namespace daima public olarak kalırlar ve başka bir erişim belirteci almazlar.
{
    public class Kullanici//Ana sınıflar sadece public ve internal erişim belirteçleri alabilir
    {
        public string Adi;//Program class ında bu değişkene ulaşmak için string in önüne public ekledik, yoksa orada erişemiyoruz
        internal string Soyadi;//Bir diğer rişim yöntemi de string in önüne internal yazmak, böylece aynı projede olduğu için bu değişken de ulaşabilir hale geliyor
        private string Telefon;//Buradaki telefon değişkeni ise private yaptığımız için program class ında gelmez ama bu class da kullanabiliriz
        protected string Email;//Bu email değişkenine de program cs den erişemeyiz protected yaptığımız için, bu sınıfta veya buradan miras alan bir sınıfta kullanabiliriz
        string sifre;
    }
    internal class Adres
    {
        private class Siparis //Ana sınıf içerisinde private ve internal erişim belirteci alabilir 
        {

        }
    }
    
}
