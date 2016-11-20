using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MouseSensitivityChanger.Models;
using WindowsLibrary;
using WindowsLibrary.Services.Interfaces;

namespace MouseSensitivityChanger
{
    public class Program
    {
        private const int MouseMinValue = 10;
        private const int MouseMaxValue = 15;

        public static void Main(string[] args)
        {
            var app = new Application(new MouseSensitivityService(), new MouseSetting() { MinValue = MouseMinValue, MaxValue = MouseMaxValue });
            app.Run();

            Thread.Sleep(1000);
        }
    }
}
