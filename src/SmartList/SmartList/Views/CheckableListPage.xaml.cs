using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartList.ViewModels;
using Xamarin.Forms;

namespace SmartList.Views
{
    public partial class CheckableListPage : ContentPage
    {
        public CheckableListPage(CheckableListVM checkableListVM) : this()
        {
            BindingContext = checkableListVM;
        }
        public CheckableListPage()
        {
            InitializeComponent();
        }

    }
}
