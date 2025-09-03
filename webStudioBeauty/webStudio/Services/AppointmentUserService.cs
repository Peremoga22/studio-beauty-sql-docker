using Microsoft.EntityFrameworkCore;

using webStudio.Data;
using webStudio.Models;

namespace webStudio.Services
{
    public class AppointmentUserService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public AppointmentUserService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void Save(AppointmentUser appointmentUser)
        {
            if (appointmentUser.Id == 0)
            {
                var result = _applicationDbContext.AppointmentUsers.Add(appointmentUser);
                if (result.State == EntityState.Added)
                {
                    _applicationDbContext.SaveChanges();
                }
            }
            else
            {
                var categoryInDbEntuty = _applicationDbContext.AppointmentUsers.Find(appointmentUser.Id);
                if (categoryInDbEntuty != null)
                {
                    _applicationDbContext.AppointmentUsers.Update(appointmentUser);
                    _applicationDbContext.SaveChanges();
                }
            }
            _applicationDbContext.SaveChanges();
        }

        public async Task<List<AppointmentUser>> GetAllCategoryListAsync()
        {
            var result = await _applicationDbContext.AppointmentUsers.Include(u => u.Categories).ToListAsync();
            return result;
        }

    }
}
