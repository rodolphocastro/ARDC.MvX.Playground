using ARDC.MvX.Playground.Core.Services;
using ARDC.MvX.Playground.Core.ViewModels.Landing;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Threading.Tasks;

namespace ARDC.MvX.Playground.Core.ViewModels
{
    /// <summary>
    /// ViewModel para a Home do Aplicativo.
    /// </summary>
    public class HomeViewModel : MvxNavigationViewModel
    {
        public HomeViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, IUserService userService) : base(logProvider, navigationService)
        {
            UserService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        private IUserService UserService { get; }

        public override async Task Initialize()
        {
            await base.Initialize();

            // Caso o usuário não esteja autenticado, redirecionar para o Landing
            if (!UserService.IsAuthenticated)
                await NavigationService.Navigate<LandingViewModel>();
        }
    }
}