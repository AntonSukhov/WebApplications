using Microsoft.EntityFrameworkCore;
using RM.DAL.DbContexts;
using RM.DAL.Entities;

namespace RM.DAL.MsSql.DbContexts
{
    /// <summary>
    /// Контекст работы с базой данных доступа
    /// </summary>
    public class AccessDbContext : DbContext, IAccessDbContext
    {
        #region Свойства

        /// <inheritdoc/>
        public DbSet<ModuleEntity> Modules { get; set; }

        #endregion

        #region Конструкторы

        /// <summary>
        /// Конструктор по умолчанию 
        /// </summary>
        /// <param name="options">Опции контекста работы с базой данных доступа</param>
        public AccessDbContext(DbContextOptions<AccessDbContext> options) : base(options) { }

        #endregion

    }
}
