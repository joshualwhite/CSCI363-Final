using System;
namespace BloodSugar.Models
{
    public class Preferences
    {
        public Boolean emailNotification { get; set; }
        public Boolean textNotification { get; set; }
        public Boolean bannerNotification { get; set; }
        public Boolean iconNotification { get; set; }
        public Boolean autoDosageEnabled { get; set; }

        public Preferences(Boolean e, Boolean t, Boolean b, Boolean i, Boolean a)
        {
            this.emailNotification = e;
            this.textNotification = t;
            this.bannerNotification = b;
            this.iconNotification = i;
            this.autoDosageEnabled = a;
        }

        public static Preferences defaults()
        {
            return new Preferences(true, true, true, true, true);
        }
    }
}
