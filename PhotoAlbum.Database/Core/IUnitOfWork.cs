using System;
using PhotoAlbum.Domain.Core.Repositories;

namespace PhotoAlbum.Domain.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IAlbumRepository Albums { get; }
        IImageRepository Images { get; }

        int Commit();
    }
}
