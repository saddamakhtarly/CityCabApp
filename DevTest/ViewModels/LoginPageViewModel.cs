using System;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;

namespace DevTest.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {



        #region Private Properties

        #endregion

        #region Public Properties

        #endregion

        #region Command
        public DelegateCommand ForgotPasswordCommand => new DelegateCommand(ForgotPasswordPage);
        #endregion

        #region Constructors
        public LoginPageViewModel(INavigationService service) : base(service)
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
        private async void ForgotPasswordPage()
        {
            await NavigationService.NavigateAsync($"{nameof(ForgotPasswordPage)}");
        }
        #endregion


    }
}
