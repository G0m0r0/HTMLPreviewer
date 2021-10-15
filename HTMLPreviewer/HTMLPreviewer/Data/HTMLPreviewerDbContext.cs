namespace HTMLPreviewer.Data
{
    using HTMLPreviewer.Data.Models;
    using Microsoft.EntityFrameworkCore;
    public class HTMLPreviewerDbContext : DbContext
    {
        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=HTMLPreviewer;Integrated Security=True;";
        public HTMLPreviewerDbContext()
        {

        }

        public HTMLPreviewerDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<HTMLBox> HTMLBoxes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }
    }
}
