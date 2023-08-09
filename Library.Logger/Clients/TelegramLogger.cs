using System.Net.Http.Json;
namespace Library.Logger.Clients
{
    public class TelegramLogger : ITelegramLogger
    {
        private readonly HttpClient _httpClient;
        private readonly string _botToken;
        private const string AlertGroupId = "-960317258";

        public TelegramLogger(string botToken)
        {
            _botToken = botToken;
            _httpClient = new HttpClient();
        }

        public async Task Log(string message)
        {
            // This is to trim top 2000. As there is limit on discord.
            if (message.Length > 1999)
            {
                message = message.Substring(0, 1998);
            }

            var url = $"https://api.telegram.org/bot{_botToken}/sendMessage";
            var data = new { chat_id = AlertGroupId, text = message };
            await _httpClient.PostAsJsonAsync(url, data);
        }
    }
}
