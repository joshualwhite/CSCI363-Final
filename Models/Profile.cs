using System;
namespace BloodSugar.Models
{
    public class Profile
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String email { get; set; }
        public String phoneNumber { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        public Profile(String fn, String ln, String email, String phone)
        {
            this.firstName = fn;
            this.lastName = ln;
            this.email = email;
            this.phoneNumber = phone;
        }

        public Profile() { }

        public static Profile newFakerInstance()
        {
            Profile profile = new Profile();

            profile.firstName = "John";
            profile.lastName = "Doe";
            profile.email = "John.Doe12@gmail.com";
            profile.phoneNumber = "555-777-0011";
            profile.createdAt = DateTime.Now;
            profile.updatedAt = DateTime.Now;

            return profile;
        }
    }
}
