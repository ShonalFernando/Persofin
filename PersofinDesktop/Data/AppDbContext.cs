using Microsoft.EntityFrameworkCore;
using PersofinDesktop.Helper;
using PersofinDesktop.Model;
using PersofinDesktop.Model.ProjectManagement;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PersofinDesktop.Data
{
    public class AppDbContext : DbContext
    {
        private readonly string _dbPath;

        // Major Personal Modules
        public DbSet<TransactionRecord> Transactions { get; set; }

        // Project Management Module
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectPaymentView> ProjectPayments { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }
        public DbSet<ProjectResource> ProjectResources { get; set; }

        // Made-To-Order Module
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPayment> OrderPayments{ get; set; }

        public AppDbContext(string dbPath)
        {
            _dbPath = dbPath;
            Directory.CreateDirectory(Path.GetDirectoryName(dbPath)!);
            Debug.WriteLine($"Databases -> Paths -> {dbPath}");
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={_dbPath}");
        }
    }
}
