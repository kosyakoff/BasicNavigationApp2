namespace BasicNavigationApp2.ViewModel
{
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Command;
    using GalaSoft.MvvmLight.Views;

    public class MainViewModel : ViewModelBase

    {
        #region Fields

        private RelayCommand _navigateCommand;
        private readonly INavigationService _navigationService;
        private string _welcomeTitle;

        #endregion

        #region Constructors

        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            WelcomeTitle = "Home Page";
            _navigateCommand = new RelayCommand(() =>navigationService.NavigateTo(ViewModelLocator.SecondPageKey));
        }

        #endregion

        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }

            set
            {
                Set(ref _welcomeTitle, value);
            }
        }
        
    }
}
