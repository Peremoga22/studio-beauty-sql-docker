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

        public int SaveClient(AppointmentUser appointmentUser)
        {
            
            if (appointmentUser.Id == 0)
            {
                var result = _applicationDbContext.AppointmentUsers.Add(appointmentUser);
                if (result.State == EntityState.Added)
                {
                    _applicationDbContext.AppointmentUsers.Add(appointmentUser);
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

            return appointmentUser.Id;
        }

        public async Task<AppointmentUser> GetClientAppointment(int categoryId)
        {
            var result = await _applicationDbContext.AppointmentUsers.FirstOrDefaultAsync(c => c.Id == categoryId);
            return result;
        }

        public async Task<List<AppointmentUser>> GetAllAppointmentUseListAsync()
        {
            var result = await _applicationDbContext.AppointmentUsers.ToListAsync();
            return result;
        }
    }
}
