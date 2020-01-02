using System;

namespace CSharp_Intern
{
    public class Person
    {
        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }
        public DateTime BirthDate { get; private set; }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Now - BirthDate;
                return timeSpan.Days / 365;
            }
        }
    }
}
