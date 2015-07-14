using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartList.Models;
using SmartList.Services;
using SmartList.ViewModels;
using Xamarin.Forms;

namespace SmartList.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var dataService = new DataService();
            var navigationService = new NavigationService(Navigation);
            var people = dataService.GetPeople();
            BindingContext = new MainPageVM(people, navigationService);
        }
    }
}
