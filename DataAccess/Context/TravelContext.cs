using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Context
{
    public class TravelContext:DbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<AdresBlog> AdresBlog { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Hakkimizda> Hakkimizda { get; set; }
        public DbSet<iletisim> iletisim { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server =(localdb)\MSSQLLocalDB;Database=Travel;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Yorum>()
            .HasOne(yorum => yorum.Blog)
            .WithMany(blog => blog.Yorumlar)
            .HasForeignKey(yorum => yorum.Blogid)
            .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
