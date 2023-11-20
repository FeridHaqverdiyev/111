namespace Project.Models
{
    public class ProductImage
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool? IsPrimary { get; set; }
        public int ProductId { get; set; }
        public Product product { get; set; }

    }
}
