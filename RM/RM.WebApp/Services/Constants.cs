namespace RM.WebApp.Services
{
    /// <summary>
    /// Сервис для работы с константами
    /// </summary>
    public static class Constants
    {
        #region Поля

        public const string CanAccessToWorkTypeDirectoryPolicy = "CanAccessToWorkTypeDirectory";

        public const string CanAccessToPerformerDirectoryPolicy = "CanAccessToPerformerDirectory";

        public const string IsAdminClaim = "IsAdmin";

        public const string IsOfficeEmployeeClaim = "IsOfficeEmployee";

        public const string IsShopEmployeeClaim = "IsShopEmployee";

        public const string DefaultConnectionString = "DefaultConnection";

        public const string DataStorageTypeString = "DataStorageType";

        public const string MsSqlServer = "MSSQL";

        public const string PostgreSql = "PostgreSQL";

        #endregion
    }
}
