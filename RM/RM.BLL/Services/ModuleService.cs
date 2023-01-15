using RM.BLL.Abstractions.Models;
using RM.BLL.Abstractions.Services;
using RM.BLL.Converters;
using RM.DAL.Abstractions.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace RM.BLL.Services
{
    /// <summary>
    /// Сервис модуля программы
    /// </summary>
    public class ModuleService : IModuleService
    {
        #region Поля

        /// <summary>
        /// Репозиторий модуля программы
        /// </summary>
        private readonly IModuleRepository _moduleRepository;

        #endregion

        #region Конструкторы

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        /// <param name="moduleRepository">Репозиторий модуля программы</param>
        public ModuleService(IModuleRepository moduleRepository)
        {
            _moduleRepository = moduleRepository;
        }

        #endregion

        #region Методы

        /// <inheritdoc/>
        public IEnumerable<ModuleModel> GetModules() => _moduleRepository.GetModules().Select(p => p.ConvertDalToBllModel());

        #endregion
    }
}
