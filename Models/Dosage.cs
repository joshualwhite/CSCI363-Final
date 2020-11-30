using System;
using System.Collections.Generic;

namespace BloodSugar.Models
{
    public class Dosage
    {
        public Guid id { get; set; }
        public Reading followingReading { get; set; }
        public DateTime timeStamp { get; set; }
        public Double amount { get; set; }
        public Boolean manual { get; set; }

        public Dosage(Guid id, DateTime timestamp, Double amount, Boolean manual = false)
        {
            this.id = id;
            this.timeStamp = timeStamp;
            this.amount = amount;
            this.manual = manual;
        }

        public static List<Dosage> newFakerListInstance()
        {
            List<Dosage> dosages = new List<Dosage>();

            for (int i = 0; i < 12; i++)
            {
                dosages.Add(new Dosage(Guid.NewGuid(), DateTime.Now, 5));
            }

            return dosages;
        }
        public String getDosageDescription()
        {
            if (this.manual) return "Administered Manually";
            return "Administered Automatically";
        }
    }
}
