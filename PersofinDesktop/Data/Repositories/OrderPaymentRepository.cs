using Microsoft.EntityFrameworkCore;
using PersofinDesktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Data.Repositories
{
    internal class OrderPaymentRepository : IRepository<OrderPayment>
    {
        private readonly AppDbContext _context;

        public OrderPaymentRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OrderPayment>> GetAllAsync()
        {
            return await _context.OrderPayments
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<OrderPayment?> GetByIdAsync(int id)
        {
            return await _context.OrderPayments.FindAsync(id);
        }

        public async Task AddAsync(OrderPayment entity)
        {
            await _context.OrderPayments.AddAsync(entity);
        }

        public async Task UpdateAsync(OrderPayment entity)
        {
            _context.OrderPayments.Update(entity);
        }

        public async Task DeleteAsync(OrderPayment entity)
        {
            _context.OrderPayments.Remove(entity);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }

}
