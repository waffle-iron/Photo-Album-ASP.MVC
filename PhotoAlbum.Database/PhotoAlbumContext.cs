using System.Data.Entity;
using PhotoAlbum.Domain.Entities;

namespace PhotoAlbum.Domain
{
    public class PhotoAlbumContext : DbContext
    {
        public PhotoAlbumContext()
            : base("name=PhotoAlbumContext")
        {
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>()
                .HasMany(e => e.Images)
                .WithRequired(e => e.Album)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Image>()
                .Property(e => e.Expansion)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .HasMany(e => e.Albums)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}