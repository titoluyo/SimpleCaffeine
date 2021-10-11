﻿using System;
using System.Runtime.InteropServices;

namespace SimpleCaffeine
{
    [Flags]
    public enum EXECUTION_STATE : uint
    {
        ES_CONTINUOUS = 0x80000000,
        ES_SYSTEM_REQUIRED = 0x00000001,
        ES_DISPLAY_REQUIRED = 0x00000002,
        ES_USER_PRESENT = 0x00000004,
        ES_AWAYMODE_REQUIRED = 0x00000040,
    }

    internal class Native
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);
    }
}
