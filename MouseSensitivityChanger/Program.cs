using WindowsLibrary;

namespace MouseSensitivityChanger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = new MouseSpeedChanger(new MouseSensitivityService(), new WindowsNotificationLogger());
            app.Execute();
        }
    }
}
