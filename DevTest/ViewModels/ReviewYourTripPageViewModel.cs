using DevTest.Models;
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
        private List<Rating> _rating;
        #endregion

        #region Public Properties

        #endregion

        #region Command
        public DelegateCommand<object> ReviewCommand => new DelegateCommand<object>(ReviewTapped);
        #endregion

        #region Constructors
        public ReviewYourTripPageViewModel(INavigationService service) : base(service)
        {
            Rating = new List<Rating>
            {
                new Rating { Star = "\uf005", },
                new Rating { Star = "\uf005", },
                new Rating { Star = "\uf005", },
                new Rating { Star = "\uf005", },
                new Rating { Star = "\uf005", },
            };
        }

        //Only run first time after Constructor
        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
        }
        #endregion

        #region Get Set
        public List<Rating> Rating
        {
            get => _rating;
            set => SetProperty(ref _rating, value);
        }
        #endregion

        #region Public Implementation

        #endregion

        #region Private Implementation
        private void ReviewTapped(object obj)
        {
            if (obj != null && obj is Rating rating)
            {
                rating.IsRated = rating.IsRated ? false : true;
            }
        }
        #endregion




    }
}
