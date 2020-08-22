using System;

namespace MVVM_WPF_Template.ViewModels
{
    public static class Log
    {
        public enum LogType
        {
            Standard,
            Warning,
            Error
        }

        public static event Action<object, Log.LogType> LogHandler;

        private static void Logger(object e, bool crash, Log.LogType type)
        {
            LogHandler(e, type);
            if (crash)
                throw new Exception(e.ToString());
        }

        #region public functions
        public static void Standard(object e, bool crash = false) => Logger(e, crash, Log.LogType.Standard);
        public static void Warning(object e, bool crash = false) => Logger(e, crash, Log.LogType.Warning);
        public static void Error(object e, bool crash = false) => Logger(e, crash, Log.LogType.Error);
        #endregion
    }
}
