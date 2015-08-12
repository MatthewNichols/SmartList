using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartList.Interfaces;
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

        public IList<CheckableList> GetLists()
        {
            return new List<CheckableList>
            {
                new CheckableList
                {
                    Id = Guid.NewGuid(),
                    Name = "Grocery List",
                    CreateDate = DateTime.Today,
                    LastModifiedDate = DateTime.Now,
                    Items = new List<CheckableListItem>
                    {
                        new CheckableListItem { Id = Guid.NewGuid(), Name = "Item 1", Complete = false },
                        new CheckableListItem { Id = Guid.NewGuid(), Name = "Item 2", Complete = false },
                        new CheckableListItem { Id = Guid.NewGuid(), Name = "Item 3", Complete = true },
                        new CheckableListItem { Id = Guid.NewGuid(), Name = "Item 4", Complete = true },
                        new CheckableListItem { Id = Guid.NewGuid(), Name = "Item 5", Complete = false },
                        new CheckableListItem { Id = Guid.NewGuid(), Name = "Item 6", Complete = false }
                    }
                }
            };
        }
    }
}
