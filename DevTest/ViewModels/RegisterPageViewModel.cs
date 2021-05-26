using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevTest.ViewModels
{
 public   class RegisterPageViewModel : BaseViewModel
    {


        #region Private Properties

        #endregion

        #region Public Properties

        #endregion

        #region Command
        
            public DelegateCommand VerifyMobile => new DelegateCommand(VerifyMobilePage);
        #endregion

        #region Constructors
        public RegisterPageViewModel(INavigationService service) : base(service)
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
        private async void VerifyMobilePage()
        {
            await NavigationService.NavigateAsync($"{nameof(VerifyMobilePage)}");
        }
        #endregion
    }
}
