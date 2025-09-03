using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using webStudio.Models;

namespace webStudio.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<AppointmentUser> AppointmentUsers => Set<AppointmentUser>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<CosmetologyTherapy> CosmetologyTherapies => Set<CosmetologyTherapy>();
        public DbSet<MassageTherapy> MassageTherapies => Set<MassageTherapy>();
        public DbSet<CosmetologyTherapyCard> CosmetologyTherapyCards => Set<CosmetologyTherapyCard>();        
        public DbSet<MassageTherapyCard> MassageTherapyCards => Set<MassageTherapyCard>();
    }
}
