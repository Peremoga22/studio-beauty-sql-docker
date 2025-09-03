using Microsoft.EntityFrameworkCore;

using webStudio.Components.Pages;
using webStudio.Data;
using webStudio.Models;

namespace webStudio.Services
{
    public class MessageService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public MessageService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void SaveTitle(MessageTherapy model)
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
    }
}
