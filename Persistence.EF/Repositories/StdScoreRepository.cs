using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.EF.Repositories
{//
    public class StdScoreRepository : IStdScoreRepository
    {
        private readonly KasraTestContext _context;

        public StdScoreRepository(KasraTestContext context)
        {
            _context = context;
        }

        public async Task Add(StdScore entity)
        {
            await _context.StdScores.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<StdScore>> GetAll()
        {
            return await _context.StdScores.ToListAsync();
        }
    }
}
