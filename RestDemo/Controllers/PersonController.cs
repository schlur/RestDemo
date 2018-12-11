using RestDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestDemo.Controllers
{
    public class PersonController : ApiController
    {
        // GET: api/Person
        public List<Person> Get()
        {
            var personList = new List<Person>();

            Address strasbourg = new Address
            {
                Country = "France",
                Town = "Strasbourg"
            };


            Person patrick = new Person
            {
                Firstname = "Patrick",
                Surname = "Schlur",
                Birthday = DateTime.Parse("26.03.1969"),
                Address = strasbourg
            };


            Address Iffezheim = new Address
            {
                Town = "Iffezheim",
                Country = "Deutschland"
            };

            Person jochen = new Person
            {
                Firstname = "Jochen",
                Surname = "Feiertag",
                Birthday = DateTime.Parse("26.03.1969"),
                Address = Iffezheim
            };

            personList.Add( patrick );
            personList.Add(jochen);

            return personList;
        }

        // GET: api/Person/5
        public Person Get(int id)
        {
            Address strasbourg = new Address
            {
                Country = "France",
                Town = "Strasbourg"
            };


            Person patrick = new Person
            {
                Firstname = "Patrick",
                Surname = "Schlur",
                Birthday = DateTime.Parse("26.03.1969"),
                Address = strasbourg
            };

            return patrick;
        }

    }
}
