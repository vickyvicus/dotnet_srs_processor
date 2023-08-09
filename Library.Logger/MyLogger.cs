using Library.Logger.Clients;
namespace Library.Logger
{
    public class MyLogger
    {
        private readonly IDiscordLogger _discordLogger;
        private readonly ITelegramLogger _telegramLogger;

        public MyLogger(IDiscordLogger discordLogger, ITelegramLogger telegramLogger)
        {
            _discordLogger = discordLogger;
            _telegramLogger = telegramLogger;
        }

        public MyLogger(IDiscordLogger discordLogger)
        {
            _discordLogger = discordLogger;
        }

        /// <summary>
        /// Creates log and sends to discord, slack.
        /// Wrapped in try catch so as to prevent original process
        /// to break if error occurs while posting logs.
        /// </summary>
        /// <param name="ex">The exception</param>
        /// <param name="data">The string representing payload data</param>
        /// <param name="stackTrace"></param>
        public async Task CreateLog(Exception ex, string data = "", string stackTrace = "")
        {
            try
            {
#if !DEBUG
                await LogToDiscord(ex, data, stackTrace);
#endif
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
        }

        private async Task LogToDiscord(Exception ex, string data = "", string stackTrace = "")
        {
            var msg = ex.GetBaseException().Message;

            var finalMsg = "🐞Error🐞";
            finalMsg = finalMsg + "\n" + msg;
            if (data != "")
            {
                finalMsg = finalMsg + "\n";
                finalMsg = finalMsg + "\n" + "----Payload START----";
                finalMsg = finalMsg + "\n" + $"{data}";
                finalMsg = finalMsg + "\n" + "----Payload END----";
            }
            if (stackTrace != "")
            {
                finalMsg = finalMsg + "\n";
                finalMsg = finalMsg + "\n" + "----StackTrace START----";
                finalMsg = finalMsg + "\n" + $"{stackTrace}";
                finalMsg = finalMsg + "\n" + "----StackTrace END----";
            }
            await _discordLogger.SaveLog(finalMsg);
        }

        public async void LogToTelegram(string message)
        {
            await _telegramLogger.Log(message);
        }
    }
}
