using Microsoft.AspNetCore.Authorization;

namespace RM.WebApp.Services.AuthorizationRequirements
{
    /// <summary>
    /// Требование возможности доступа пользователя к справочнику типов работ
    /// </summary>
    public class CanAccessToWorkTypeDirectoryRequirement : IAuthorizationRequirement
    {
        #region Свойства

        /// <summary>
        /// Пользователь является администратором
        /// </summary>
        public bool IsAdmin { get; set; }

        /// <summary>
        /// Пользователь является сотрудником магазина
        /// </summary>
        public bool IsShopEmployee { get; set; }

        #endregion
    }
}
