namespace WindowsForms_EntityFramework_Code_First_01
{
    public class Product
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public decimal UrunFiyati { get; set; }
        public int StokMiktari { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
