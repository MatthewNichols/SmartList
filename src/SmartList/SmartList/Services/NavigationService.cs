using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartList.ViewModels;
using SmartList.Views;
using Xamarin.Forms;

namespace SmartList.Services
{
    public class NavigationService
    {
        private readonly INavigation _navigation;

        public NavigationService(INavigation navigation)
        {
            _navigation = navigation;
        }

        public void NavigateToPerson(PersonVM personVM)
        {
            _navigation.PushAsync(new PersonPage(personVM));
        }
    }
}
