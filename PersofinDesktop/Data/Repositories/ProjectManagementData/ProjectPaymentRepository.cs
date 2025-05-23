﻿using Microsoft.EntityFrameworkCore;
using PersofinDesktop.Model.ProjectManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Data.Repositories
{
    internal class ProjectPaymentRepository : IRepository<ProjectPaymentView>
    {
        private readonly AppDbContext _context;

        public ProjectPaymentRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProjectPaymentView>> GetAllAsync()
        {
            return await _context.ProjectPayments.AsNoTracking().ToListAsync();
        }

        public async Task<ProjectPaymentView?> GetByIdAsync(int id)
        {
            return await _context.ProjectPayments.FindAsync(id);
        }

        public async Task AddAsync(ProjectPaymentView entity)
        {
            await _context.ProjectPayments.AddAsync(entity);
        }

        public async Task UpdateAsync(ProjectPaymentView entity)
        {
            _context.ProjectPayments.Update(entity);
        }

        public async Task DeleteAsync(ProjectPaymentView entity)
        {
            _context.ProjectPayments.Remove(entity);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
