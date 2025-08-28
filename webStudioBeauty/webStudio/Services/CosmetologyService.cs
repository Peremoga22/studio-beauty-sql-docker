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

        public void Save(CosmetologyTherapy cosmetology)
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
    }
}
