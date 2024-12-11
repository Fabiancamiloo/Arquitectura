namespace NorthWind.ConsoleApp.Services;

internal class AppLogger(IEnumerable<IUserActionWriter> writers)
{
    public void Writelog(string message)
    {
        UserAction Log = new UserAction("System", message);
        foreach(var Writer in writers)
        Writer.Write(Log);
    }
}
