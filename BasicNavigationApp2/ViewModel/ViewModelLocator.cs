namespace BasicNavigationApp2.ViewModel
{
    using CommonServiceLocator;

    using GalaSoft.MvvmLight.Ioc;

    public class ViewModelLocator
    {
        #region Constants

        public const string SecondPageKey = "SecondPage";

        #endregion

        #region Properties

        public MainViewModel Main { get; } = ServiceLocator.Current.GetInstance<MainViewModel>();

        #endregion

        #region Constructors

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
        }

        #endregion

        #region Methods

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }

        #endregion
    }
}
