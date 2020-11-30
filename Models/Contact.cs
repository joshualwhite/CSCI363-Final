using System;
using System.Collections.Generic;

namespace BloodSugar.Models
{
    public class Contact : Profile
    {
        public Boolean medicalAdvisor { get; set; }
        public String secondayNumber { get; set; }

        public Contact(String fn, String ln, String email, String phone, Boolean medicalAdvisor ) : base(fn, ln, email, phone)
        {
            this.medicalAdvisor = medicalAdvisor;
        }

        private void super(string fn, string ln, string email, string phone)
        {
            throw new NotImplementedException();
        }

        public static List<Contact> newFakerListInstance()
        {
            string[] firstNames = new string[] { "Aaron", "Abby" };
            string[] lastNames = new string[] { "Abbott", "Acosta" };
            string[] emails = new string[] { "aabbot@tester.com", "abbyacosta1234@the.com" };
            string[] phones = new string[] { "777-654-3210", "999-888-1234" };

            List<Contact> contacts = new List<Contact>();
            contacts.Add(new Contact(firstNames[0], lastNames[0], emails[0], phones[0], true));
            contacts.Add(new Contact(firstNames[1], lastNames[1], emails[1], phones[1], false));

            return contacts;
        }
    }
}