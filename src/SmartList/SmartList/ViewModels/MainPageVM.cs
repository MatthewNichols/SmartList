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

        public MainPageVM(IEnumerable<Person> people, NavigationService navigationService)
        {
            _navigationService = navigationService;
            Items = people.Select(p => new PersonVM(p)).ToList();
        }

        public IList<PersonVM> Items { get; set; }
        
        private PersonVM _selectedItem;
        public PersonVM SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if (value != _selectedItem)
                {
                    _selectedItem = value;
                    _navigationService.NavigateToPerson(SelectedItem);
                }
            }
        }
    }
}
