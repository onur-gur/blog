namespace blog.root
{
    using Microsoft.Extensions.DependencyInjection;
    using business.repositories;
    using business.services;
    using data.context;
    using Microsoft.EntityFrameworkCore;
    public class CompositionRoot
    {
        public CompositionRoot() { }

        public static void InjectDependencies(IServiceCollection services)
        {
            services.AddScoped<blogcontext>();
            services.AddScoped(typeof(IPostRepository), typeof(PostService));
            services.AddScoped(typeof(IPostImageRepository), typeof(PostImageService));
            services.AddScoped(typeof(ICategoryRepository), typeof(CategoryService));
            services.AddDbContext<blogcontext>(options =>
            options.UseSqlServer("server=94.73.150.5;uid=u8924044_blog;database=u8924044_blog; pwd=RUnd60J5DJnt42W", x => x.MigrationsAssembly("blog.ui")));
        }
    }
}