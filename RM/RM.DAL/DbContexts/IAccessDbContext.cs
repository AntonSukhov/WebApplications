using Microsoft.EntityFrameworkCore;
using RM.DAL.Entities;

namespace RM.DAL.DbContexts
{
    /// <summary>
    /// Контекст работы с базой данных доступа
    /// </summary>
    public interface IAccessDbContext
    {
        #region Свойства

        /// <summary>
        /// Модули программы
        /// </summary>
        DbSet<ModuleEntity> Modules { get; set; }

        #endregion
    }
}
