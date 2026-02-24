using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_CalisanSistemiOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee dev = new Developer();

            dev.Name = "Test";
            dev.Salary = 3000;
            dev.Info();
            dev.CalculateBonus();
        }
    }
    abstract class Employee
    {
        public string Name {  get; set; }
        public decimal Salary {  get; set; }
        public void Info() 
        {
            Console.WriteLine(Name);
            Console.WriteLine(Salary);
        }
        public abstract void CalculateBonus();
    }
    class Developer : Employee
    {
        public override void CalculateBonus()
        {
            decimal bonus = Salary * 0.10m;
            Console.WriteLine($"Alınan bonus: {bonus}");
        }
    }
    class Manager : Employee
    {
        public override void CalculateBonus()
        {
            decimal bonus = Salary * 0.30m;
            Console.WriteLine($"Alınan bonus: {bonus}");
        }
    }
    class Intern : Employee
    {
        public override void CalculateBonus()
        {
            Console.WriteLine("Intern için bonus yok");
        }
    }
}
