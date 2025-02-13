namespace EksamensOpgaveBackend.Models
{
    public class ProductModel
    {

        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? ImageUrl { get; set; }
        public int YearOfProduction { get; set; }
    }
}
