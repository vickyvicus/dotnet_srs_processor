namespace Library.Logger.Clients
{
    public interface IDiscordLogger
    {
        Task Log(string message);
        Task SaveLog(string message);
    }
}
