using Prism.Navigation;

namespace ExtendingKidsDiet.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Test";
        }
    }
}