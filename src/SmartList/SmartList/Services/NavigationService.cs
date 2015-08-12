using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartList.Interfaces;
using SmartList.ViewModels;
using SmartList.Views;
using Xamarin.Forms;

namespace SmartList.Services
{
    public class NavigationService : INavigationService
    {
        private readonly INavigation _navigation;

        public NavigationService(INavigation navigation)
        {
            _navigation = navigation;
        }

        public void NavigateToCheckableList(CheckableListVM checkableListVM)
        {
            _navigation.PushAsync(new CheckableListPage(checkableListVM));
        }
    }
}
