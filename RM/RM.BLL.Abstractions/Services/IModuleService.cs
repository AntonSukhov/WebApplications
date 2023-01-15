using RM.BLL.Abstractions.Models;
using System.Collections.Generic;

namespace RM.BLL.Abstractions.Services
{
    /// <summary>
    /// Сервис модуля программы
    /// </summary>
    public interface IModuleService
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
