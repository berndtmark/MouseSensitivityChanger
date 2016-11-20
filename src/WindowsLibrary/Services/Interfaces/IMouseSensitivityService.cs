using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindowsLibrary.Services.Interfaces
{
    public interface IMouseSensitivityService
    {
        void SetMouseSpeed(int mouseSpeed);

        int GetMouseSpeed();
    }
}
