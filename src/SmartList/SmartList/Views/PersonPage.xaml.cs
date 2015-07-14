using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartList.ViewModels;
using Xamarin.Forms;

namespace SmartList.Views
{
    public partial class PersonPage : ContentPage
    {
        public PersonPage(PersonVM personVM) : this()
        {
            BindingContext = personVM;
        }
        public PersonPage()
        {
            InitializeComponent();
        }

    }
}
