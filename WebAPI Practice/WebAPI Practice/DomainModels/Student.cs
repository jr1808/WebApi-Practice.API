using System;


namespace WebAPI_Practice.DomainModels
{
    public class Student
    {
        public Guid ID { get; set; }
        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
        public string ProfileImageUrl { get; set; }
        public Guid GenderID { get; set; }

        // Navigation properties

        public Gender gender { get; set; }
        public Address address { get; set; }


    }
}

