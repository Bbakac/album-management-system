using Microsoft.EntityFrameworkCore;
using ProjeKlasoru.Models;

namespace ProjeKlasoru.Data
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options) { }

        public DbSet<TblAlbum>? Tbl_Album { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAlbum>(entity =>
            {
                entity.Property(e => e.Album_Fiyat).HasColumnType("TEXT");
            });
        }
    }
}
