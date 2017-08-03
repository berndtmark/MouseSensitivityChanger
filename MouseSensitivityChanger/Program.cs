using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WindowsLibrary;
using WindowsLibrary.Services.Interfaces;

namespace MouseSensitivityChanger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = new MouseSpeedChanger(new MouseSensitivityService(), new ConsoleLogger());
            app.Execute();

            Thread.Sleep(1000);
        }
    }
}
