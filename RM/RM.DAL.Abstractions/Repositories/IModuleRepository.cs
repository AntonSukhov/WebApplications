using RM.DAL.Abstractions.Models;
using System.Collections.Generic;

namespace RM.DAL.Abstractions.Repositories
{
    /// <summary>
    /// Репозиторий модуля программы
    /// </summary>
    public interface IModuleRepository
    {
        #region Методы

        /// <summary>
        /// Получение коллекции модулей
        /// </summary>
        /// <returns>Коллекция модулей</returns>
        IEnumerable<ModuleModel> GetModules();

        #endregion
    }
}
