using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SmartList.Models;

namespace SmartList.ViewModels
{
    public class CheckableListVM : ViewModelBase
    {
        public CheckableListVM(CheckableList list)
        {
            Id = list.Id;
            Name = list.Name;
            CreateDate = list.CreateDate;
            LastModifiedDate = list.LastModifiedDate;

            Items = list.Items.Select(item => new CheckableListItemVM(item));
            
        }

        private bool _showCompleted = false;
        public Boolean ShowCompleted {
            get { return _showCompleted;}
            set
            {
                if (value != _showCompleted)
                {
                    _showCompleted = value;
                    RaisePropertyChanged(() => ShowCompleted);
                    RaisePropertyChanged(() => VisibleItems);
                }
            } }
        
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public IEnumerable<CheckableListItemVM> Items { get; set; }

        public IEnumerable<CheckableListItemVM> VisibleItems => _showCompleted ? Items : Items.Where(item => !item.Complete);
    }

    public class CheckableListItemVM : ViewModelBase
    {
        public CheckableListItemVM(CheckableListItem item)
        {
            Id = item.Id;
            Name = item.Name;
            Complete = item.Complete;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        private bool _complete;

        public bool Complete
        {
            get { return _complete; }
            set
            {
                if (value != _complete)
                {
                    _complete = value;
                    RaisePropertyChanged(() => Complete);
                }
            }
        }

    }
}
