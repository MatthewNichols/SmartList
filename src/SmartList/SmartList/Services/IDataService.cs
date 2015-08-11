using System.Collections.Generic;
using SmartList.Models;

namespace SmartList.Services
{
    public interface IDataService
    {
        IList<Person> GetPeople();
    }
}