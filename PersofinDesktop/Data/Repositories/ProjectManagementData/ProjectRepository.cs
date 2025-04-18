using Microsoft.EntityFrameworkCore;
using PersofinDesktop.Model;
using PersofinDesktop.Model.ProjectManagement;

namespace PersofinDesktop.Data.Repositories
{
    internal class ProjectRepository : IRepository<PersofinDesktop.Model.Project>
    {
        private readonly AppDbContext _context;

        public ProjectRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Project>> GetAllAsync()
        {
            return await _context.Projects.AsNoTracking().ToListAsync();
        }

        public async Task<Project?> GetByIdAsync(int id)
        {
            return await _context.Projects.FindAsync(id);
        }

        public async Task AddAsync(Project entity)
        {
            await _context.Projects.AddAsync(entity);
        }

        public async Task UpdateAsync(Project entity)
        {
            _context.Projects.Update(entity);
        }

        public async Task DeleteAsync(Project entity)
        {
            _context.Projects.Remove(entity);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        // Extended methods handling relationships
        public async Task<IEnumerable<ProjectPayment>> GetPaymentsForProjectAsync(int projectId)
        {
            return await _context.ProjectPayments
                .Where(p => p.ProjectId == projectId)
                .AsNoTracking()
                .ToListAsync();
        }

        // Getting project with payments
        public async Task<Project?> GetProjectWithPaymentsAsync(int id)
        {
            return await _context.Projects
                .Include(p => p.Payments)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
