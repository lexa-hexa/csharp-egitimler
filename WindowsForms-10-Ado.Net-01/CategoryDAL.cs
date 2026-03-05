using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;//SQL Bağlantısı kurmak için 


namespace WindowsForms_10_Ado.Net_01
{
    public class CategoryDAL
    {
        SqlConnection _connection = new SqlConnection(@"server=.; initial catalog = UrunYonetimi; Integrated security = True");
        void ConnectionKontrol()
        {
            if(_connection.State == ConnectionState.Closed)//Bağlantı durum kontrolü
            {
                _connection.Open();
            }
        }
        public void Add(Category entity)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("Insert Into Categories Values (@KategoriAdi)", _connection);
            command.Parameters.AddWithValue("@KategoriAdi", entity.KategoriAdi);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public DataTable GetDataTable()
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("Select * From Categories", _connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;
        }
        public void Update(Category entity)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("Update Categories set KategoriAdi=@KategoriAdi where Id=@Id", _connection);
            command.Parameters.AddWithValue(@"Id", entity.Id);
            command.Parameters.AddWithValue("@KategoriAdi", entity.KategoriAdi);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public void Delete(int id)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("Delete from Categories where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
