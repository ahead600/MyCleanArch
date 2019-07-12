using MyCleanArch.Application.Interfaces;
using MyCleanArch.Application.Services;
using MyCleanArch.Domain.Interfaces;
using MyCleanArch.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace MyCleanArch.Infra.IoC
{
    public static class DependencyContainer
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ICourseService, CourseService>();
        }
    }
}
