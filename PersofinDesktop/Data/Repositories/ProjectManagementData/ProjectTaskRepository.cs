using Microsoft.EntityFrameworkCore;
using PersofinDesktop.Model.ProjectManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Data.Repositories
{
    internal class ProjectTaskRepository : IRepository<ProjectTask>
    {
        private readonly AppDbContext _context;

        public ProjectTaskRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProjectTask>> GetAllAsync()
        {
            return await _context.ProjectTasks.AsNoTracking().ToListAsync();
        }

        public async Task<ProjectTask?> GetByIdAsync(int id)
        {
            return await _context.ProjectTasks.FindAsync(id);
        }

        public async Task AddAsync(ProjectTask entity)
        {
            await _context.ProjectTasks.AddAsync(entity);
        }

        public async Task UpdateAsync(ProjectTask entity)
        {
            _context.ProjectTasks.Update(entity);
        }

        public async Task DeleteAsync(ProjectTask entity)
        {
            _context.ProjectTasks.Remove(entity);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
