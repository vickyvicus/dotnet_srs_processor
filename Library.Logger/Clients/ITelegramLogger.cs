namespace Library.Logger.Clients
{
    public interface ITelegramLogger
    {
        Task Log(string message);
    }
}
