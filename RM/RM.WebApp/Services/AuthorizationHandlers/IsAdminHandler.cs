using Microsoft.AspNetCore.Authorization;
using RM.WebApp.Services.AuthorizationRequirements;
using System.Threading.Tasks;

namespace RM.WebApp.Services.AuthorizationHandlers
{
    /// <summary>
    /// Обработчик является ли пользователь администратором для требования <see cref="CanAccessToWorkTypeDirectoryRequirement"/>
    /// </summary>
    public class IsAdminHandler : AuthorizationHandler<CanAccessToWorkTypeDirectoryRequirement>
    {
        #region Методы

        /// <inheritdoc/>
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, CanAccessToWorkTypeDirectoryRequirement requirement)
        {
            if (context.User.HasClaim(Constants.IsAdminClaim, bool.TrueString))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }

        #endregion
    }
}
