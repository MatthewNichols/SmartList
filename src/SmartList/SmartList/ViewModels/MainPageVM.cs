using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SmartList.Models;
using SmartList.Services;
using SmartList.Views;
using Xamarin.Forms;

namespace SmartList.ViewModels
{
    public class MainPageVM : ViewModelBase
    {
        private readonly NavigationService _navigationService;

        public MainPageVM(IEnumerable<CheckableList> lists, NavigationService navigationService)
        {
            _navigationService = navigationService;
            Items = lists.Select(p => new CheckableListVM(p)).ToList();
        }

        public IList<CheckableListVM> Items { get; set; }
        
        private CheckableListVM _selectedItem;
        public CheckableListVM SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if (value != _selectedItem)
                {
                    _selectedItem = value;
                    _navigationService.NavigateToCheckableList(SelectedItem);
                }
            }
        }
    }
}
