using Microsoft.AspNetCore.Authorization;
using RM.WebApp.Services.AuthorizationRequirements;
using System.Threading.Tasks;

namespace RM.WebApp.Services.AuthorizationHandlers
{
    /// <summary>
    /// Обработчик является ли пользователь сотрудником магазина для требования <see cref="CanAccessToWorkTypeDirectoryRequirement"/>
    /// </summary>
    public class IsShopEmployeeHandler : AuthorizationHandler<CanAccessToWorkTypeDirectoryRequirement>
    {
        #region Методы

        /// <inheritdoc/>
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, CanAccessToWorkTypeDirectoryRequirement requirement)
        {
            if (context.User.HasClaim(Constants.IsShopEmployeeClaim, bool.TrueString))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }

        #endregion
    }
}
