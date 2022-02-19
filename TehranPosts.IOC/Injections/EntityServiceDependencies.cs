
using TehranPosts.Domain.InterfaceRepositories;
using TehranPosts.Data;
using TehranPosts.Core.InterfaceServices;
using TehranPosts.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace TehranPosts.IOC.Injections
{
    public static class EntityServiceDependencies
    {
        public static void RegisterEntityServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient(typeof(IBaseRepositoryAsync<>), typeof(BaseRepository<>));
            services.AddTransient(typeof(IBaseServiceAsync<>), typeof(BaseServiceAsync<>));
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IPostService, PostService>();
            services.AddTransient<IBlogService, BlogService>();
        }
    }
}
