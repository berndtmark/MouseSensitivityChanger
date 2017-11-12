using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowLibrary.Libraries;

namespace MouseSensitivityChanger
{
    public class WindowsNotificationLogger : ILogger
    {
        public void Write(string text)
        {
            StringBuilder content = new StringBuilder();
            content.Append(text);

            WindowsNotification.Show(content);
        }
    }
}
