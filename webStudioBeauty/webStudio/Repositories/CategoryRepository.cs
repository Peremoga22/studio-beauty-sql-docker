using Microsoft.EntityFrameworkCore;

using webStudio.Data;
using webStudio.Models;

namespace webStudio.Repositories
{
    public class CategoryRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void Save(Category category)
        {
            if (!string.IsNullOrEmpty(category.Id))
            {
                var result = _applicationDbContext.Categories.Add(category);
                if (result.State == EntityState.Added)
                {
                    _applicationDbContext.SaveChanges();
                }
            }
            else
            {
                var categoryInDbEntuty = _applicationDbContext.Categories.Find(category.Id);
                if (categoryInDbEntuty != null)
                {
                    _applicationDbContext.Categories.Update(category);
                    _applicationDbContext.SaveChanges();
                }
            }
            _applicationDbContext.SaveChanges();
        }
    }
}
