using FiorelloBack.Data;
using FiorelloBack.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FiorelloBack.Services
{
    public class SocialService : ISocialService
    {
        private readonly AppDbContext _context;
        public SocialService(AppDbContext context)
        {
            _context = context;
        }
               
            public async Task<Dictionary<string, string>> GetAllAsync()
            {
                return await _context.Settings.ToDictionaryAsync(m => m.Key, m => m.Value);
            }
        
    }
}
