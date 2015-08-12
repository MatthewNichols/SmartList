using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.ServiceLocation;
using SmartList.Interfaces;
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
            var dataService = ServiceLocator.Current.GetInstance<IDataService>();
            var navigationService = new NavigationService(Navigation);
            var lists = dataService.GetLists();
            BindingContext = new MainPageVM(lists, navigationService);
        }
    }
}
