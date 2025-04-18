using Microsoft.EntityFrameworkCore;
using PersofinDesktop.Model.ProjectManagement;
using PersofinDesktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Data.Repositories
{
    internal class ProjectResourceRepository : IRepository<ProjectResource>
    {
        private readonly AppDbContext _context;

        public ProjectResourceRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProjectResource>> GetAllAsync()
        {
            return await _context.ProjectResources.AsNoTracking().ToListAsync();
        }

        public async Task<ProjectResource?> GetByIdAsync(int id)
        {
            return await _context.ProjectResources.FindAsync(id);
        }

        public async Task AddAsync(ProjectResource entity)
        {
            await _context.ProjectResources.AddAsync(entity);
        }

        public async Task UpdateAsync(ProjectResource entity)
        {
            _context.ProjectResources.Update(entity);
        }

        public async Task DeleteAsync(ProjectResource entity)
        {
            _context.ProjectResources.Remove(entity);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
