using Prism.Mvvm;
using Prism.Navigation;

namespace DevTest.ViewModels
{
    public class BaseViewModel : BindableBase, IInitialize, INavigationAware, IDestructible
    {
     

        #region Private Properties
        private string _title;
        private bool _isBusy;
        #endregion

        #region Public Properties
        public INavigationService NavigationService { get; private set; }
        #endregion

        #region Command

        #endregion

        #region Constructors
        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
        #endregion

        #region Get Set
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public bool IsBusy
        {
            get { return _isBusy; }
            set { SetProperty(ref _isBusy, value); }
        }
        #endregion

        #region Public Implementation
        public virtual void Destroy()
        { }

        public virtual void Initialize(INavigationParameters parameters)
        { }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        { }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        { }
        #endregion

        #region Private Implementation

        #endregion



    }
}
