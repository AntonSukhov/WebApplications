using RM.DAL.Abstractions.Models;
using RM.DAL.Entities;
using System;

namespace RM.DAL.Converters
{
    /// <summary>
    /// Конвертер сущности модуля программы
    /// </summary>
    internal static class ModuleEntityConverter
    {
        #region Методы

        /// <summary>
        /// Конвертирование сущности модуля программы уровня DAL в модель модуля программы уровня BLL
        /// </summary>
        /// <param name="moduleModel">Сущность модуля программы уровная DAL</param>
        /// <returns>Модель модуля программы уровная BLL</returns>
        public static ModuleModel ConvertDalToBllModel(this ModuleEntity module)
        {
            if (module == null)
            {
                throw new ArgumentNullException(nameof(module));
            }

            return new ModuleModel
            {
                Id = module.Id,
                Name = module.Name,
                Description = module.Description
            };
        }

        #endregion
    }
}
