using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevTest.ViewModels
{
    public class ReviewYourTripPageViewModel : BaseViewModel
    {

        #region Private Properties
        private bool _isClicked;
        #endregion

        #region Public Properties

        #endregion

        #region Command
        public DelegateCommand ReviewCommand => new DelegateCommand(ReviewTapped);

        #endregion

        #region Constructors
        public ReviewYourTripPageViewModel(INavigationService service) : base(service)
        {
            
        }

        //Only run first time after Constructor
        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
        }
        #endregion

        #region Get Set
        public bool IsClicked
        {
            get => _isClicked;
            set => SetProperty(ref _isClicked, value);
        }
        #endregion

        #region Public Implementation

        #endregion

        #region Private Implementation
        private void ReviewTapped()
        {
            if (IsClicked)
            {
                IsClicked = false;
            }
            else
                IsClicked = true;
        }
        #endregion




    }
}
