using System;
namespace BloodSugar.Models
{
    public class OperatingState
    {
        public AppModes AppMode { get; set; }

        public Boolean manualEntryEnabled { get; set; }
        public OperatingState(AppModes a, Boolean mee)
        {
            this.AppMode = a;
            this.manualEntryEnabled = mee;
        }

        public static  OperatingState defaults()
        {
            return new OperatingState(AppModes.Auto, false);
        }

        public enum AppModes
        {
            Auto,
            Manual,
            Off
        }

        public String getCurrentModeDescription()
        {
            if (this.AppMode == AppModes.Auto) return ("Currently in Automatic Mode");
            else if (this.AppMode == AppModes.Manual) return ("Currently in Manual Mode");
            return "The Application is Off";

        }
    }

}
