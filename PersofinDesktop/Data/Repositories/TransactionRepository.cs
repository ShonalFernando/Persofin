using Microsoft.EntityFrameworkCore;
using PersofinDesktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Data.Repositories
{
    public class TransactionRepository : IRepository<TransactionRecord>
    {
        private readonly AppDbContext _context;

        public TransactionRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TransactionRecord>> GetAllAsync()
        {
            return await _context.Transactions.AsNoTracking().ToListAsync();
        }

        public async Task<TransactionRecord?> GetByIdAsync(int id)
        {
            return await _context.Transactions.FindAsync(id);
        }

        public async Task AddAsync(TransactionRecord entity)
        {
            await _context.Transactions.AddAsync(entity);
        }

        public async Task UpdateAsync(TransactionRecord entity)
        {
            _context.Transactions.Update(entity);
        }

        public async Task DeleteAsync(TransactionRecord entity)
        {
            _context.Transactions.Remove(entity);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
