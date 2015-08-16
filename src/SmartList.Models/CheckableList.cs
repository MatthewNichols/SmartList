using System;
using System.Collections.Generic;

namespace SmartList.Models
{
    public class CheckableList
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModifiedDate { get; set; }

        public List<CheckableListItem> Items { get; set; }

        public CheckableListDesc ToDescription()
        {
            return new CheckableListDesc
            {
                Id = this.Id,
                Name = this.Name,
                CreateDate = this.CreateDate,
                LastModifiedDate = this.LastModifiedDate
            };
        }
    }

    public class CheckableListDesc
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }

    public class CheckableListItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Complete { get; set; }
    }
}
