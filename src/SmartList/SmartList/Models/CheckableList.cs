using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartList.Models
{
    public class CheckableList
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModifiedDate { get; set; }

        public List<CheckableListItem> Items { get; set; }
    }

    public class CheckableListItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Complete { get; set; }
    }
}
