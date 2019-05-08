using ARDC.MvX.Playground.Core.Generators;
using ARDC.MvX.Playground.Core.Models;
using ARDC.MvX.Playground.Core.Services;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace ARDC.MvX.Playground.Core.ViewModels.Services
{
    /// <summary>
    /// ViewModel para listagem de serviços.
    /// </summary>
    public class ServiceListViewModel : MvxNavigationViewModel
    {
        public ServiceListViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, IServiceItemService itemService) : base(logProvider, navigationService)
        {
            ItemService = itemService ?? throw new System.ArgumentNullException(nameof(itemService));

            Servicos = new MvxObservableCollection<ServiceItem>();
            HomeCommand = new MvxAsyncCommand(NavigateToHomeAsync);
            DetailServiceCommand = new MvxAsyncCommand<ServiceItem>(NavigateToServiceDetailAsync);
            AddServiceCommand = new MvxAsyncCommand(NavigateToServiceCreateAsync);
        }

        private IServiceItemService ItemService { get; }

        /// <summary>
        /// Command para detalhar um serviço.
        /// </summary>
        public IMvxAsyncCommand<ServiceItem> DetailServiceCommand { get; private set; }

        /// <summary>
        /// Command para adicionar um novo serviço.
        /// </summary>
        public IMvxAsyncCommand AddServiceCommand { get; private set; }

        /// <summary>
        /// Command para retornar à Home.
        /// </summary>
        public IMvxAsyncCommand HomeCommand { get; private set; }

        private MvxObservableCollection<ServiceItem> _servicos;

        public MvxObservableCollection<ServiceItem> Servicos
        {
            get { return _servicos; }
            set { _servicos = value; }
        }


        public override async Task Initialize()
        {
            await base.Initialize();

            Servicos.AddRange(await ItemService.GetAllAsync());
        }

        /// <summary>
        /// Navega á tela de detalhamento de serviços.
        /// </summary>
        /// <param name="service">O serviço a ser detalhado</param>
        private async Task NavigateToServiceDetailAsync(ServiceItem service) => await NavigationService.Navigate<ServiceDetailViewModel, int>(service.Id);

        /// <summary>
        /// Navega à tela criação de serviços.
        /// </summary>
        private Task NavigateToServiceCreateAsync()
        {
            // TODO: Refatorar para permitir que o cadastro seja feito pelo usuário
            Servicos.Add(ServiceItemGenerator.GenerateServiceItem());
            // TODO: Exibir um Toast / Aviso que foi cadastrado um novo serviço
            return Task.CompletedTask;
        }

        /// <summary>
        /// Navega à Home do App.
        /// </summary>
        private async Task NavigateToHomeAsync() => await NavigationService.Navigate<HomeViewModel>();
    }
}
