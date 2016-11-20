using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MouseSensitivityChanger.Models;
using WindowsLibrary.Enums;
using WindowsLibrary.Services.Interfaces;

namespace MouseSensitivityChanger
{
    public class Application
    {
        private readonly IMouseSensitivityService _mouseSensitivityService;
        private MouseSetting _settings;

        public Application(IMouseSensitivityService mouseSensitivityService, MouseSetting settings)
        {
            _mouseSensitivityService = mouseSensitivityService;
            _settings = settings;
        }

        public void Run()
        {
            var currentMouseSpeed = _mouseSensitivityService.GetMouseSpeed();
            int newSpeed = 0;

            Console.WriteLine($"Current speed is: {currentMouseSpeed}");

            if (currentMouseSpeed == _settings.MaxValue)
            {
                newSpeed = ChangeSpeed(_settings.MinValue);
            }
            else if (currentMouseSpeed == _settings.MinValue)
            {
                newSpeed = ChangeSpeed(_settings.MaxValue);
            }
            else
            {
                newSpeed = ChangeSpeed((int)MouseSpeed.Default);
            }

            Console.WriteLine($"New speed is: {newSpeed}");
        }

        private int ChangeSpeed(int speed)
        {
            _mouseSensitivityService.SetMouseSpeed(speed);
            return speed;
        }
    }
}
