namespace NorthWind.Writers;

public class FileWrite : IUserActionWriter
{
    public void Write(UserAction action)
    {
        File.AppendAllText("AppLogs.txt",
            string.Format("FileWriter: {0}, {1}, {2}",
            action.CreatedDateTiem, action.User, action.Description));
    }
}
