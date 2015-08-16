using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using SmartList.Interfaces;
using SmartList.Models;
using SQLite;
using SQLite.Net;

namespace SmartList.Services
{
    public class DataService : IDataService
    {
        public IList<CheckableList> GetLists()
        {
            return new List<CheckableList> {
               CreateExampleCheckableList()
            };
        }

        private static CheckableList CreateExampleCheckableList()
        {
            return new CheckableList
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
            };
        }
    }
}
