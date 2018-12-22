using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BasicNavigationApp2.Helpers
{
    using GalaSoft.MvvmLight.Ioc;
    using GalaSoft.MvvmLight.Threading;
    using GalaSoft.MvvmLight.Views;

    using ViewModel;

    public static class App
    {
        private static ViewModelLocator _locator;
        private static NavigationService _nav = new NavigationService();

        public static ViewModelLocator Locator
        {
            get
            {
                if (_locator == null)
                {
                    DispatcherHelper.Initialize();

                    SimpleIoc.Default.Register<INavigationService>(() => _nav);

                    _nav.Configure(ViewModelLocator.SecondPageKey,typeof(SecondActivity));
                    
                    _locator = new ViewModelLocator();
                }

                return _locator;
            }
        }
    }
}