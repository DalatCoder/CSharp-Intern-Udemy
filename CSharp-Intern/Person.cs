using System;
using System.Collections.Generic;

namespace CSharp_Intern
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get
            {
                return _dictionary[key];
            }
            set
            {
                _dictionary[key] = value;
            }
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; private set; }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Now - BirthDate;
                return timeSpan.Days / 365;
            }
        }

        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }
    }
}
