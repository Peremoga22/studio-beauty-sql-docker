using webStudio.Components.Pages;

namespace webStudio.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string NameCategory { get; set; }
        public List<CosmetologyTherapy> Cosmetologies { get; set; } = new List<CosmetologyTherapy>();
        public List<MessageTherapy> Messages { get; set; } = new List<MessageTherapy>();
        public string UserId { get; set; }
    }
}
