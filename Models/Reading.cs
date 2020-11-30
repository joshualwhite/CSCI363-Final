using System;
using System.Collections.Generic;

namespace BloodSugar.Models
{
    public class Reading
    {
        public Guid id { get; }
        public DateTime timestamp { get; set; }
        public Double reading { get; set; }
        public String units { get; set; }

        public Reading(Guid id, DateTime timestamp, Double reading, String units ="mg/dl")
        {
            this.id = id;
            this.timestamp = timestamp;
            this.reading = reading;
            this.units = units;
        }

        public static List<Reading> newFakerListInstance()
        {
            List<Reading> readings = new List<Reading>();

            for(int i=0; i<12; i++)
            {
                readings.Add(new Reading(Guid.NewGuid(), DateTime.Now, 134));
            }

            return readings;
        }

        public String getReadingDescription()
        {
            if (this.reading < 80) return "Your current blood sugar is low.";
            else if (this.reading > 180) return "Your current blood sugar is high.";
            return "Your blood sugar is within healthy ranges.";
        }
    }
}
