using Microsoft.EntityFrameworkCore;
using SolrDotnetSample.Repositories.Models;

namespace SolrDotnetSample.Repositories.Contexts
{
    public class SolrDotnetSampleContext : DbContext
    {
        public SolrDotnetSampleContext(DbContextOptions options)
            : base(options) { }

        public DbSet<PostModel> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SolrDotnetSampleContext).Assembly);
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}