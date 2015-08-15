using System.Collections.Generic;
using SmartList.Models;

namespace SmartList.Interfaces
{
    public interface IDataService
    {
        IList<CheckableList> GetLists();
    }
}