using webStudio.Components.Pages;

namespace webStudio.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string NameCategory { get; set; }
        public List<CosmetologyTherapy> Cosmetologies { get; set; } = new List<CosmetologyTherapy>();
        public List<MassageTherapy> Messages { get; set; } = new List<MassageTherapy>();
        public string UserId { get; set; }
    }
}
