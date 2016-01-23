using PhotoAlbum.Domain.Core;
using PhotoAlbum.Domain.Core.Repositories;
using PhotoAlbum.Domain.Persistence.Repositories;

namespace PhotoAlbum.Domain.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PhotoAlbumContext _context;

        public UnitOfWork(PhotoAlbumContext context)
        {
            _context = context;

            Users = new UserRepository(_context);
            Albums = new AlbumRepository(_context);
            Images = new ImageRepository(_context);
        }

        public IUserRepository Users { get; }
        public IAlbumRepository Albums { get; }
        public IImageRepository Images { get; }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
