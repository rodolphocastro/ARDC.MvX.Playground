using ARDC.MvX.Playground.Core.Services;
using ARDC.MvX.Playground.Core.ViewModels.Landing;
using ARDC.MvX.Playground.Core.ViewModels.News;
using MvvmCross.Commands;
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

            NavigateToNewsCommand = new MvxAsyncCommand(NavigateToNewsList);
        }

        private IUserService UserService { get; }

        /// <summary>
        /// Command para acessar a lista de notícias.
        /// </summary>
        public IMvxAsyncCommand NavigateToNewsCommand { get; private set; }


        public override async void ViewAppearing()
        {
            // Caso o usuário não esteja autenticado, redirecionar para o Landing
            if (!UserService.IsAuthenticated)
                await NavigationService.Navigate<LandingViewModel>();

            base.ViewAppearing();
        }

        /// <summary>
        /// Navega até a VM de lista de notícias.
        /// </summary>
        private async Task NavigateToNewsList() => await NavigationService.Navigate<NewsListViewModel>();
    }
}