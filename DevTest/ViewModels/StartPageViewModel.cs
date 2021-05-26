using DevTest.Views;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevTest.ViewModels
{
    public class StartPageViewModel : BaseViewModel
    {

        #region Private Properties

        #endregion

        #region Public Properties

        #endregion

        #region Command
        public DelegateCommand RegisterCommand => new DelegateCommand(RegisterPage);
        public DelegateCommand LoginCommand => new DelegateCommand(LoginPage);
        //public DelegateCommand ResetpasswordCommand => new DelegateCommand(ResetPasswordTapped);
        #endregion

        #region Constructors
        public StartPageViewModel(INavigationService service) : base(service)
        {
        }

        //Only run first time after Constructor
        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
        }
        #endregion

        #region Get Set

        #endregion

        #region Public Implementation

        #endregion

        #region Private Implementation
        private async void RegisterPage()
        {
            await NavigationService.NavigateAsync($"{nameof(RegisterPage)}");
        }
        private async void LoginPage()
        {
            await NavigationService.NavigateAsync($"{nameof(LoginPage)}");
        }
        #endregion


    }
}
