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
                var result = _applicationDbContext.MassageTherapies.Add(model);
                if (result.State == EntityState.Added)
                {
                    _applicationDbContext.SaveChanges();
                }
            }
            else
            {
                var categoryInDbEntuty = _applicationDbContext.MassageTherapies.Find(model.Id);
                if (categoryInDbEntuty != null)
                {
                    _applicationDbContext.MassageTherapies.Update(model);
                    _applicationDbContext.SaveChanges();
                }
            }
            _applicationDbContext.SaveChanges();
        }

        public async Task<List<Models.MassageTherapy>> GetAllMassageTherapyListAsync()
        {
            var result = await _applicationDbContext.MassageTherapies.ToListAsync();
            return result;
        }

        public async Task<Models.MassageTherapy> EditMassageTherapyFirstOrDefaultAsync()
        {
            var result = await _applicationDbContext.MassageTherapies.FirstOrDefaultAsync() ?? new  Models.MassageTherapy();
            return result;
        }

        public async Task<List<MassageTherapyCard>> GetAllMassageTherapyCardListAsync()
        {
            var result = await _applicationDbContext.MassageTherapyCards.ToListAsync();
            return result;
        }
    }
}
