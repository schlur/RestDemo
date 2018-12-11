using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestDemo.Models
{
    public class Person
    {
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public DateTime Birthday { get; set; }

        public Address Address { get; set; }
    }
}