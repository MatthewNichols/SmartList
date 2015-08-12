using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartList.Models;

namespace SmartList.ViewModels
{
    public class CheckableListVM
    {
        public CheckableListVM(CheckableList list)
        {
            Id = list.Id;
            Name = list.Name;
            CreateDate = list.CreateDate;
            LastModifiedDate = list.LastModifiedDate;

            Items = list.Items.Select(item => new CheckableListItemVM(item));
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public IEnumerable<CheckableListItemVM> Items { get; set; }

    }

    public class CheckableListItemVM
    {
        public CheckableListItemVM(CheckableListItem item)
        {
            Id = item.Id;
            Name = item.Name;
            Complete = item.Complete;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Complete { get; set; }
    }
}
