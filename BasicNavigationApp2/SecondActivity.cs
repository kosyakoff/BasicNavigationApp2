namespace BasicNavigationApp2
{
    using Android.App;
    using Android.OS;
    using Android.Widget;

    using CommonServiceLocator;

    using GalaSoft.MvvmLight.Views;

    [Activity(Label = "Second Page")]
    public class SecondActivity : ActivityBase
    {
        #region Fields

        private Button _backButton;

        #endregion

        #region Methods

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Second);

            var nav = (NavigationService)ServiceLocator.Current.GetInstance<INavigationService>();

            BackButton.Click += (s, e) => nav.GoBack();

            // Create your application here
        }

        #endregion

        public Button BackButton
        {
            get
            {
                return _backButton ?? (_backButton = FindViewById<Button>(Resource.Id.backButton));
            }
        }
    }
}
