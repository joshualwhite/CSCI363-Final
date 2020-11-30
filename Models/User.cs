using System;
using System.Collections.Generic;

namespace BloodSugar.Models
{
    public class User
    {
        public Guid id { get; set; } 
        public Profile profile { get; set; }
        public int pin { get; set; }
        public List<Contact> advisors { get; set; }
        public List<Reading> readingHistory { get; set; }
        public List<Dosage> dosageHistory { get; set; }
        public OperatingState operatingState { get; set; }
        public Preferences preferences { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        public static User newFakerInstance()
        {
            User user = new User();

            user.id = Guid.NewGuid();
            user.pin = 1234;
            user.createdAt = DateTime.Now;
            user.updatedAt = DateTime.Now;
            user.profile = Profile.newFakerInstance();
            user.advisors = Contact.newFakerListInstance();
            user.readingHistory = Reading.newFakerListInstance();
            user.dosageHistory = Dosage.newFakerListInstance();
            user.operatingState = OperatingState.defaults();
            user.preferences = Preferences.defaults();

            return user; 
        }
    }
}
