using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Serialization;//SQL Bağlantısı kurmak için 

namespace WindowsForms_10_Ado.Net_01
{
    public class ProductDAL
    {
        SqlConnection _connection = new SqlConnection(@"server=.; initial catalog=UrunYonetimi; Integrated security = True");
        void ConnectionKontrol()
        {
            if(_connection.State == ConnectionState.Closed)//Bağlantı durumu kontrolü
            {
                _connection.Open();
            }
        }

        public void Add(Product product)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("Insert Into Products values (@UrunAdi, @UrunFiyati, @StokMiktari)", _connection);
            command.Parameters.AddWithValue("@UrunAdi", product.UrunAdi);
            command.Parameters.AddWithValue("@UrunFiyati", product.UrunFiyati);
            command.Parameters.AddWithValue("@StokMiktari", product.StokMiktari);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public List<Product> GetProducts()
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("Select * From Products", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Product> Products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    UrunAdi = reader["UrunAdi"].ToString(),
                    UrunFiyati = Convert.ToDecimal(reader["UrunFiyati"]),
                    StokMiktari = Convert.ToInt32(reader["StokMiktari"])
                };
                Products.Add(product);
            }
            reader.Close();
            _connection.Close();
            return Products;
        }
        public void Update(Product product)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("Update Products set UrunAdi=@UrunAdi, UrunFiyati=@UrunFiyati, StokMiktari=@StokMiktari where Id=@Id", _connection); 
            command.Parameters.AddWithValue("@Id", product.Id);
            command.Parameters.AddWithValue("@UrunAdi", product.UrunAdi);
            command.Parameters.AddWithValue("@UrunFiyati", product.UrunFiyati);
            command.Parameters.AddWithValue("@StokMiktari", product.StokMiktari);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public void Delete(int id)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("Delete From Products where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
