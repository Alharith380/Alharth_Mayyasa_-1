using System;


namespace project.Classes
{
    using System;

    namespace project.Classes
    {
        public sealed class Marketer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string PhoneNumber { get; set; }
            public string NationalId { get; set; }
            public DateTime CreatedAt { get; set; }

            public Marketer() { }

            public Marketer(int id, string firstName, string lastName, int age, string phone, string nationalId)
            {
                if (firstName == null) throw new ArgumentNullException("firstName");
                if (lastName == null) throw new ArgumentNullException("lastName");
                if (phone == null) throw new ArgumentNullException("phone");
                if (nationalId == null) throw new ArgumentNullException("nationalId");

                Id = id;
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                PhoneNumber = phone;
                NationalId = nationalId;
                CreatedAt = DateTime.Now;
            }

            public string FullName => FirstName + " " + LastName;
        }

    }
}