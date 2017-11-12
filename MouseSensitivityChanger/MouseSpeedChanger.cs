using System;
using WindowLibrary.Constants;
using WindowsLibrary.Services.Interfaces;

namespace MouseSensitivityChanger
{
    public class MouseSpeedChanger
    {
        private readonly IMouseSensitivityService _mouseSensitivityService;
        private readonly ILogger _logger;

        public MouseSpeedChanger(IMouseSensitivityService mouseSensitivityService, ILogger logger)
        {
            _mouseSensitivityService = mouseSensitivityService;
            _logger = logger;
        }

        public void Execute()
        {
            var currentMouseSpeed = _mouseSensitivityService.GetMouseSpeed();

            switch (currentMouseSpeed)
            {
                case MouseSpeed.Fast:
                    ChangeSpeed(MouseSpeed.Normal);
                    break;
                case MouseSpeed.Normal:
                    ChangeSpeed(MouseSpeed.Fast);
                    break;
                default:
                    ChangeSpeed(MouseSpeed.Normal);
                    break;
            }
        }

        private void ChangeSpeed(int speed)
        {
            _mouseSensitivityService.SetMouseSpeed(speed);
            _logger.Write($"Mouse speed changed to: {speed}");
        }
    }
}
