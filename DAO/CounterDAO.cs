using BusinessObjects.Context;
using BusinessObjects.Models;
using DAO.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class CounterDAO : Singleton<CounterDAO>
    {
        private readonly JssatsContext _context;
        public CounterDAO()
        {
            _context = new JssatsContext();
        }
        public async Task<Counter?> GetById(int id)
        {
            return await _context.Counters.FindAsync(id);
        }
        public async Task<IEnumerable<Counter>?> Gets()
        {
            return await _context.Counters.Include(x => x.Users).ToListAsync();
        }

        public async Task<int> Create(Counter jewelryType)
        {
            _context.Counters.Add(jewelryType);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> Update(int id, Counter jewelryType)
        {
            var existingCounter = await _context.Counters
                .FirstOrDefaultAsync(w => w.CounterId == id);
            jewelryType.CounterId = id;
            if (existingCounter == null) return 0;
            _context.Entry(existingCounter).CurrentValues.SetValues(jewelryType);
            _context.Entry(existingCounter).State = EntityState.Modified;

            return await _context.SaveChangesAsync();
        }
    }
}
