using Microsoft.EntityFrameworkCore;
using PortfolioCore.Entities;

namespace PortfolioCore.Context
{
    public class PortfolioContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-G6TTPQ6;initial Catalog=PortfolioNightDb;integrated security=true;trust server certificate=true;");
        }

        public DbSet<Contact>contacts { get; set; }
        public DbSet<Education>educations{ get; set; }
        public DbSet<Experience>experiences { get; set; }
        public DbSet<Message>messages{ get; set; }
        public DbSet<Testimonial>testimonials { get; set; }
        public DbSet<Skill>skills { get; set; }
        public DbSet<Category>categories { get; set; }
        public DbSet<Portfolio>portfolios { get; set; }
        public DbSet<SocialMedia>SocialMedias { get; set; }
        public DbSet<Future>Futures { get; set; }
        public DbSet<About>Abouts { get; set; }
        public DbSet<Service>Services { get; set; }
        
        
        
    }
}
