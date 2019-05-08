using ARDC.MvX.Playground.Core.Models;
using ARDC.MvX.Playground.Core.Services;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Threading.Tasks;

namespace ARDC.MvX.Playground.Core.ViewModels.Services
{
    /// <summary>
    /// ViewModel para a criação de Serviços.
    /// </summary>
    public class ServiceCreateViewModel : MvxNavigationViewModel
    {
        public ServiceCreateViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, IServiceItemService itemService) : base(logProvider, navigationService)
        {
            ItemService = itemService ?? throw new ArgumentNullException(nameof(itemService));

            ListCommand = new MvxAsyncCommand(NavigateToListAsync);
            CreateServiceCommand = new MvxAsyncCommand(CreateService);
        }

        /// <summary>
        /// Command para salvar o serviço.
        /// </summary>
        public IMvxAsyncCommand CreateServiceCommand { get; private set; }

        /// <summary>
        /// Command para retornar à listagem de Serviços.
        /// </summary>
        public IMvxAsyncCommand ListCommand { get; private set; }

        private IServiceItemService ItemService { get; }

        private ServiceItem _servico;

        /// <summary>
        /// Serviço sendo criado.
        /// </summary>
        public ServiceItem Servico
        {
            get { return _servico; }
            set { SetProperty(ref _servico, value); }
        }

        /// <summary>
        /// Persiste um novo serviço no sistema.
        /// </summary>
        private async Task CreateService()
        {
            await ItemService.AddAsync(Servico);      // TODO: Adicionar validações
            await NavigationService.Close(this);
        }

        /// <summary>
        /// Navega à listagem de serviços.
        /// </summary>
        private async Task NavigateToListAsync() => await NavigationService.Navigate<ServiceListViewModel>();

    }
}
