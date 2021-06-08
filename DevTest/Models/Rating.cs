using Prism.Mvvm;

namespace DevTest.Models
{
    public class Rating : BindableBase
    {
        private bool _isRated;
        public string Star { get; set; }
        public bool IsRated
        {
            get => _isRated;
            set => SetProperty(ref _isRated, value);
        }
    }
}
