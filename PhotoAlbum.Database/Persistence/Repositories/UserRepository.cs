using System.Data.Entity;
using PhotoAlbum.Domain.Core.Repositories;
using PhotoAlbum.Domain.Entities;

namespace PhotoAlbum.Domain.Persistence.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        } 
    }
}
