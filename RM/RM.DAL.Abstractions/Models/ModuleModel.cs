namespace RM.DAL.Abstractions.Models
{
    /// <summary>
    /// Модель модуля программы
    /// </summary>
    public class ModuleModel
    {
        #region Свойства

        /// <summary>
        /// ИД модуля
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Название модуля
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание модуля
        /// </summary>
        public string Description { get; set; }

        #endregion
    }
}
