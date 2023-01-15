using RM.DAL.Abstractions.Models;
using RM.DAL.Abstractions.Repositories;
using RM.DAL.Converters;
using RM.DAL.DbContexts;
using System.Collections.Generic;
using System.Linq;

namespace RM.DAL.Repositories
{
    /// <summary>
    /// Репозиторий модуля программы
    /// </summary>
    public class ModuleRepository : IModuleRepository
    {
        #region Поля

        /// <summary>
        /// Контекст работы с базой данных доступа
        /// </summary>
        private readonly IAccessDbContext _accessDbContext;

        #endregion

        #region Конструкторы

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        /// <param name="accessDbContext">Контекст работы с базой данных доступа</param>
        public ModuleRepository(IAccessDbContext accessDbContext)
        {
            _accessDbContext = accessDbContext;
        }

        #endregion

        #region Методы

        /// <inheritdoc/>
        public IEnumerable<ModuleModel> GetModules() => _accessDbContext.Modules.Select(p => p.ConvertDalToBllModel())
                                                                                .ToList();

        #endregion
    }
}
