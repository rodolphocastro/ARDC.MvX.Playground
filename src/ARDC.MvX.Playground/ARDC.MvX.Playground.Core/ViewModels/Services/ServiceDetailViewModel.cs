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
    public class ServiceDetailViewModel : MvxNavigationViewModel<int>
    {
        public ServiceDetailViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, IServiceItemService itemService) : base(logProvider, navigationService)
        {
            ItemService = itemService ?? throw new ArgumentNullException(nameof(itemService));

            ListCommand = new MvxAsyncCommand(NavigateToListAsync);
        }

        private int serviceId;

        private IServiceItemService ItemService { get; }

        private ServiceItem _servico;

        /// <summary>
        /// Serviço a ser detalhado.
        /// </summary>
        public ServiceItem Servico
        {
            get { return _servico; }
            set { SetProperty(ref _servico, value); }
        }

        /// <summary>
        /// Command para retornar à listagem de Serviços.
        /// </summary>
        public IMvxAsyncCommand ListCommand { get; private set; }

        public override void Prepare(int parameter)
        {
            serviceId = parameter;
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            Servico = await ItemService.GetAsync(serviceId);
        }

        /// <summary>
        /// Navega à listagem de serviços.
        /// </summary>
        private async Task NavigateToListAsync() => await NavigationService.Navigate<ServiceListViewModel>();
    }
}
