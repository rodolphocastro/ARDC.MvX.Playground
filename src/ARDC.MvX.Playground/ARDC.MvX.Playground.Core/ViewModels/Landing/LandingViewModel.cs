namespace ARDC.MvX.Playground.Core.ViewModels.Landing
{
    using ARDC.MvX.Playground.Core.ViewModels.Auth;
    using MvvmCross.Commands;
    using MvvmCross.Logging;
    using MvvmCross.Navigation;
    using MvvmCross.ViewModels;
    using System.Threading.Tasks;

    /// <summary>
    /// View Model para o Landing do App.
    /// </summary>
    public class LandingViewModel : MvxNavigationViewModel
    {
        public LandingViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            LoginCommand = new MvxAsyncCommand(NavigateToLogin);
        }

        /// <summary>
        /// Command para navegar ao Login
        /// </summary>
        public IMvxAsyncCommand LoginCommand { get; private set; }

        /// <summary>
        /// Navega ao ViewModel de Login.
        /// </summary>
        private async Task NavigateToLogin() => await NavigationService.Navigate<LoginViewModel>();
    }
}
