using Ninject.Modules;
using Ninject.Web.Common;
using PhotoAlbum.Domain.Core;
using PhotoAlbum.Domain.Core.Repositories;
using PhotoAlbum.Domain.Persistence;
using PhotoAlbum.Domain.Persistence.Repositories;

namespace PhotoAlbum.Domain.Ninject
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<PhotoAlbumContext>().ToSelf().InRequestScope();

            Bind(typeof(IRepository<>)).To(typeof(Repository<>));
            Bind<IUnitOfWork>().To<UnitOfWork>();

            Bind<IUserRepository>().To<UserRepository>();
            Bind<IAlbumRepository>().To<AlbumRepository>();
            Bind<IImageRepository>().To<ImageRepository>();
        }
    }
}
