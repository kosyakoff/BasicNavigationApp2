namespace BasicNavigationApp2
{
    using System;
    using System.Collections.Generic;

    using Android.App;
    using Android.OS;
    using Android.Widget;

    using GalaSoft.MvvmLight.Helpers;
    using GalaSoft.MvvmLight.Views;

    using Helpers;

    using ViewModel;

    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : ActivityBase
    {
        #region Fields

        private readonly List<Binding> _bindings = new List<Binding>();

        private Button _navigateButton;

        private TextView _welcomeText;

        #endregion

        #region Methods

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            try
            {
                _bindings.Add(this.SetBinding(() => MainViewModel.WelcomeTitle, () => WelcomeText.Text));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //throw;
            }

            NavigateButton.SetCommand("Click", MainViewModel.NavigateCommand);
        }

        #endregion

        private MainViewModel MainViewModel
        {
            get
            {
                return App.Locator.MainViewModel;
            }
        }

        public TextView WelcomeText
        {
            get
            {
                return _welcomeText ?? (_welcomeText = FindViewById<TextView>(Resource.Id.WelcomeText));
            }
        }

        public Button NavigateButton
        {
            get
            {
                return _navigateButton ?? (_navigateButton = FindViewById<Button>(Resource.Id.navigateButton));
            }
        }
    }
}
