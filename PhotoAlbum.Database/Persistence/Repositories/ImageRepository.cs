using System.Data.Entity;
using PhotoAlbum.Domain.Core.Repositories;
using PhotoAlbum.Domain.Entities;

namespace PhotoAlbum.Domain.Persistence.Repositories
{
    public class ImageRepository : Repository<Image>, IImageRepository
    {
        public ImageRepository(DbContext context) : base(context)
        {
        } 
    }
}
