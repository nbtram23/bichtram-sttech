using bichtram.Debugging;

namespace bichtram
{
    public class bichtramConsts
    {
        public const string LocalizationSourceName = "bichtram";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "69a87a701b644c709e011df3328fbc45";
    }
}
