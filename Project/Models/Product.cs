namespace Project.Models
{
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public decimal Price{ get; set; }
        public string image { get; set; }
        public string SKU { get; set; } 
        public string desc { get; set; }
        public int  CategoryId { get; set; }

        public Category category { get; set; }
        public List<ProductImage>?  productImages { get; set; }
    }
}
