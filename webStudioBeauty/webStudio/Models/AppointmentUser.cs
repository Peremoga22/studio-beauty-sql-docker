using System.ComponentModel;

namespace webStudio.Models
{
    public class AppointmentUser
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly SetHour { get; set; }
        public int CategoryId { get; set; }
        public int ServiceId { get; set; }
        public List<Category> Categories { get; set; } = new ();
    }
}
