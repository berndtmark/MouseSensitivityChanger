using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace WindowsLibrary.Libraries
{
    public static class SystemParametersInfoLib
    {
        public const uint GetMouseSpeed = 0x0070;
        public const uint SetMouseSpeed = 0x0071;

        [DllImport("user32.dll")]
        public static extern bool SystemParametersInfo(
            UInt32 uiAction,
            UInt32 uiParam,
            UInt32 pvParam,
            UInt32 fWinIni);

        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo", SetLastError = true)]
        public static extern bool SystemParametersInfoByRef(UInt32 uiAction,
            UInt32 uiParam,
            out UInt32 pvParam,
            UInt32 fWinIni);
    }
}
