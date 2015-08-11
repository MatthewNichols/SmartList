using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartList.Models;

namespace SmartList.Services
{
    public class DataService : IDataService
    {
        public IList<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person
                {
                    FirstName = "Matthew",
                    LastName = "Nichols",
                    Email = "blah@blah.com",
                    Phone = "303 867-5309",
                    Birthday = DateTime.Today.Subtract(TimeSpan.FromDays(30*365)),
                    Id = 123
                },
                new Person
                {
                    FirstName = "Mary",
                    LastName = "Camacho",
                    Email = "blah@blah.com",
                    Phone = "303 867-5309",
                    Birthday = DateTime.Today.Subtract(TimeSpan.FromDays(30*365)),
                    Id = 123
                },
            };
        }
    }
}
