namespace webStudio.Models
{
    public class CosmetologyTherapy
    {
        public int Id { get; set; }
        public string TitlePage { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string TitleCard { get; set; }
        public string DescriptionCard { get; set; }
        public decimal Price { get; set; }   
        public string CategoryId { get; set; }
        public Category Category { get; set; } = default!;       
    }
}
