using Microsoft.EntityFrameworkCore;

using webStudio.Components.Pages;
using webStudio.Data;
using webStudio.Models;



namespace webStudio.Services
{
    public class MassageService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public MassageService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void SaveTitle(Models.MassageTherapy model)
        {
            if (model.Id == 0)
            {
                var result = _applicationDbContext.MessageTherapies.Add(model);
                if (result.State == EntityState.Added)
                {
                    _applicationDbContext.SaveChanges();
                }
            }
            else
            {
                var categoryInDbEntuty = _applicationDbContext.MessageTherapies.Find(model.Id);
                if (categoryInDbEntuty != null)
                {
                    _applicationDbContext.MessageTherapies.Update(model);
                    _applicationDbContext.SaveChanges();
                }
            }
            _applicationDbContext.SaveChanges();
        }

        public async Task<List<Models.MassageTherapy>> GetAllMassageTherapyListAsync()
        {
            var result = await _applicationDbContext.MessageTherapies.ToListAsync();
            return result;
        }

    }
}
