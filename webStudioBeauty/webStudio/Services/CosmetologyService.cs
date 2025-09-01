using Microsoft.EntityFrameworkCore;

using webStudio.Data;
using webStudio.Models;

namespace webStudio.Services
{
    public class CosmetologyService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public CosmetologyService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void SaveTitle(CosmetologyTherapy cosmetology)
        {
            if (cosmetology.Id == 0)
            {
                var result = _applicationDbContext.CosmetologyTherapies.Add(cosmetology);
                if (result.State == EntityState.Added)
                {
                    _applicationDbContext.SaveChanges();
                }
            }
            else
            {
                var categoryInDbEntuty = _applicationDbContext.CosmetologyTherapies.Find(cosmetology.Id);
                if (categoryInDbEntuty != null)
                {
                    _applicationDbContext.CosmetologyTherapies.Update(cosmetology);
                    _applicationDbContext.SaveChanges();
                }
            }
            _applicationDbContext.SaveChanges();
        }

        public void SaveCosmetologyTherapyCard(CosmetologyTherapyCard cosmetologyCard)
        {
            if (cosmetologyCard.Id == 0)
            {
                var result = _applicationDbContext.CosmetologyTherapyCards.Add(cosmetologyCard);
                if (result.State == EntityState.Added)
                {
                    _applicationDbContext.SaveChanges();
                }
            }
            else
            {
                var categoryInDbEntuty = _applicationDbContext.CosmetologyTherapyCards.Find(cosmetologyCard.Id);
                if (categoryInDbEntuty != null)
                {
                    _applicationDbContext.CosmetologyTherapyCards.Update(cosmetologyCard);
                    _applicationDbContext.SaveChanges();
                }
            }
            _applicationDbContext.SaveChanges();
        }

        public async Task<List<CosmetologyTherapyCard>> GetAllCosmetologyTherapyCardListAsync()
        {
            var result = await _applicationDbContext.CosmetologyTherapyCards.ToListAsync();
            return result;
        }

        public async Task<CosmetologyTherapy> EditCosmetologyTherapyFirstOrDefaultAsync()
        {
            var result = await _applicationDbContext.CosmetologyTherapies.FirstOrDefaultAsync();
            return result;
        }

        public async Task<List<CosmetologyTherapy>> GetAllCosmetologyTherapy()
        {
            var result = await _applicationDbContext.CosmetologyTherapies.ToListAsync();
            return result;
        }

        public async Task<CosmetologyTherapyCard> EditCosmetologyTherapyCard(int cosmetologyId)
        {
            var result = _applicationDbContext.CosmetologyTherapyCards.FirstOrDefault(e => e.Id == cosmetologyId);
            return await Task.FromResult(result);
        }
    }
}
