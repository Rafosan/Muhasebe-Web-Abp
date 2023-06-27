using MuhasebeWeb.Debugging;

namespace MuhasebeWeb
{
    public class MuhasebeWebConsts
    {
        public const string LocalizationSourceName = "MuhasebeWeb";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "12d5c9156b0b4984a5103a62eb6a8574";
    }
}
