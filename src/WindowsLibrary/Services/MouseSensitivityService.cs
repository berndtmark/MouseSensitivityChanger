using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using WindowsLibrary.Libraries;
using WindowsLibrary.Services.Interfaces;

namespace WindowsLibrary
{
    public class MouseSensitivityService : IMouseSensitivityService
    {
        public void SetMouseSpeed(int mouseSpeed)
        {
            var mouseSpeedValue = Convert.ToUInt32(mouseSpeed);

            if (!ValidateInput(mouseSpeedValue))
            {
                throw new ArgumentException("Mouse speed must be between 1 and 20.");
            }

            SystemParametersInfoLib.SystemParametersInfo(
                SystemParametersInfoLib.SetMouseSpeed,
                0,
                mouseSpeedValue,
                0);
        }

        public int GetMouseSpeed()
        {
            uint mouseSpeed;

            SystemParametersInfoLib.SystemParametersInfoByRef(SystemParametersInfoLib.GetMouseSpeed, 0, out mouseSpeed, 0);

            return Convert.ToInt32(mouseSpeed);
        }


        private static bool ValidateInput(uint mouseSpeed)
        {
            if (mouseSpeed < 1 || mouseSpeed > 20)
            {
                return false;
            }

            return true;
        }
    }
}
