using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace WindowLibrary.Libraries
{
    public static class WindowsNotification
    {
        public static void Show(StringBuilder content)
        {
            var xmlContent = CreateXmlToast(content);
            var toast = new ToastNotification(xmlContent);

            ToastNotificationManager.CreateToastNotifier("MouseSensitivityChanger").Show(toast);
        }

        private static XmlDocument CreateXmlToast(StringBuilder content)
        {
            var xDoc = new XDocument(
               new XElement("toast",
               new XElement("visual",
               new XElement("binding", new XAttribute("template", "ToastGeneric"),
               new XElement("text", "Mouse Sensitivity Changer"),
               new XElement("text", content)
            )
            // ACTIONS
            //),  
            //new XElement("actions",
            //new XElement("action", new XAttribute("activationType", "background"),
            //new XAttribute("content", "Yes"), new XAttribute("arguments", "yes")),
            //new XElement("action", new XAttribute("activationType", "background"),
            //new XAttribute("content", "No"), new XAttribute("arguments", "no"))
            )));

            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xDoc.ToString());
            return xmlDoc;
        }
    }
}
