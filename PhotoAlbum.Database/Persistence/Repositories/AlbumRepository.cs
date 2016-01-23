using PhotoAlbum.Domain.Core.Repositories;
using PhotoAlbum.Domain.Entities;

namespace PhotoAlbum.Domain.Persistence.Repositories
{
    public class AlbumRepository: Repository<Album>, IAlbumRepository
    {
        public AlbumRepository(PhotoAlbumContext context) : base(context)
        {
        } 
    }
}
