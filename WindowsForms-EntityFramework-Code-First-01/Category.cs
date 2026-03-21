using System.Collections.Generic;

namespace WindowsForms_EntityFramework_Code_First_01
{
    public class Category
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public List<Product> Product {  get; set; }
    }
}
