using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database sql = new SqlServer();
            sql.Add();
            sql.Delete();

            Console.Read();
        }
    }
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Ekleme başarılı!");
        }
        public abstract void Delete();

        public abstract void Update();

        public abstract void Get();
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Kayıt sql dan silindi!");
        }

        public override void Get()
        {
            Console.WriteLine("Kayıt sql serverdan getirildi");
        }

        public override void Update()
        {
            Console.WriteLine("Kayıt sql server da güncellendi!");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Kayıt oracle dan silindi!");
        }

        public override void Get()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
    class MySql : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Kayıt mysql den silindi!");
        }

        public override void Get()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
