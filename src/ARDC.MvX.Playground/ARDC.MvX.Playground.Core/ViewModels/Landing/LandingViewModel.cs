namespace ARDC.MvX.Playground.Core.ViewModels.Landing
{
    using MvvmCross.Logging;
    using MvvmCross.Navigation;
    using MvvmCross.ViewModels;

    /// <summary>
    /// View Model para o Landing do App.
    /// </summary>
    public class LandingViewModel : MvxNavigationViewModel
    {
        public LandingViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
        }
    }
}
