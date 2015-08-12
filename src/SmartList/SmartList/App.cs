using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using SmartList.Interfaces;
using SmartList.Services;
using Xamarin.Forms;

namespace SmartList
{
    public class App : Application
    {
        public App()
        {
            SetupServiceLocator();
            // The root page of your application
            MainPage = new NavigationPage( new Views.MainPage());
        }

        private static void SetupServiceLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<IDataService, DataService>();
            SimpleIoc.Default.Register<INavigationService, NavigationService>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
