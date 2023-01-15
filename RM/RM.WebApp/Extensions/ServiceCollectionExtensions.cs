using ContractGpdWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RM.BLL.Abstractions.Services;
using RM.BLL.Services;
using RM.DAL.Abstractions.Repositories;
using RM.DAL.DbContexts;
using RM.DAL.MsSql.DbContexts;
using RM.DAL.Repositories;
using RM.WebApp.Services;

namespace RM.WebApp.Extensions
{
    /// <summary>
    /// Расширение функционала объекта <see cref="IServiceCollection"/>
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        #region Методы

        /// <summary>
        /// Регистрация контекстов баз данных в коллекцию сервисов 
        /// </summary>
        /// <param name="services">Коллекция сервисов</param>
        /// <param name="configuration">Конфигурация свойств приложения</param>
        public static void RegisterDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString(Constants.DefaultConnectionString)));

            if (configuration.GetValue<string>(Constants.DataStorageTypeString) == Constants.MsSqlServer)
            {
                services.AddDbContext<IAccessDbContext, AccessDbContext>(options => options.UseSqlServer(configuration.GetConnectionString(Constants.DefaultConnectionString)));
            }
        }

        /// <summary>
        /// Регистрация репозиториев в коллекцию сервисов
        /// </summary>
        /// <param name="services">Коллекция сервисов</param>
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IModuleRepository, ModuleRepository>();
        }

        /// <summary>
        /// Регистрация сервисов в коллекцию сервисов
        /// </summary>
        /// <param name="services">Коллекция сервисов</param>
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IModuleService, ModuleService>();
        }

        #endregion
    }
}
