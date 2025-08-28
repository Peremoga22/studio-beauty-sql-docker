using webStudio.Data;

namespace webStudio.Services
{
    public class CosmetologyService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public CosmetologyService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
    }
}
