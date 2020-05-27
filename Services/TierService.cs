using System.Linq;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;
using Banana_E_Commerce_API.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface ITierService
    {
        Task<Tier> GetByIdAsync(int tierId);
        Task<Tier> GetFirstOrDefaultByTierOptionAsync(TierEnum tierOption);
    }

    public class TierService : ITierService
    {
        private readonly DataContext _context;

        public TierService(
            DataContext context
        )
        {
            _context = context;
        }

        public async Task<Tier> GetByIdAsync(int tierId)
        {
            return await _context.Tiers
                .SingleOrDefaultAsync(t => t.Id == tierId &&
                    t.IsDeleted == false);
        }

        public async Task<Tier> GetFirstOrDefaultByTierOptionAsync(TierEnum tierOption)
        {
            return await _context.Tiers
                .Where(t => t.TierOption == tierOption &&
                    t.IsDeleted == false)
                .FirstOrDefaultAsync();
        }
    }
}