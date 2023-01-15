using RM.BLL.Abstractions.Models;
using System;

namespace RM.BLL.Converters
{
    /// <summary>
    /// Конвертер модели модуля программы
    /// </summary>
    internal static class ModuleModelConverter
    {
        #region Методы

        /// <summary>
        /// Конвертирование модели модуля программы уровня DAL в модель модуля программы уровня BLL
        /// </summary>
        /// <param name="moduleModel">Модель модуля программы уровная DAL</param>
        /// <returns>Модель модуля программы уровная BLL</returns>
        public static ModuleModel ConvertDalToBllModel(this RM.DAL.Abstractions.Models.ModuleModel moduleModel)
        {
            if (moduleModel == null)
            {
                throw new ArgumentNullException(nameof(moduleModel));
            }

            return new ModuleModel
            {
                Id = moduleModel.Id,
                Name = moduleModel.Name,
                Description = moduleModel.Description
            };
        }

        #endregion
    }
}
