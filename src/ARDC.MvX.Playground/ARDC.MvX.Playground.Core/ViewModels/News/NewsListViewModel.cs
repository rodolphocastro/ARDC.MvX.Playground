using ARDC.MvX.Playground.Core.Models;
using ARDC.MvX.Playground.Core.Services;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Threading.Tasks;

namespace ARDC.MvX.Playground.Core.ViewModels.News
{
    public class NewsListViewModel : MvxNavigationViewModel
    {
        public NewsListViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, INewsPostService newsPostService) : base(logProvider, navigationService)
        {
            NewsService = newsPostService ?? throw new ArgumentNullException(nameof(newsPostService));

            HomeCommand = new MvxAsyncCommand(NavigateToHomeAsync);
            DetailNewsPostCommand = new MvxAsyncCommand<NewsPost>(NavigateToNewsDetailAsync);
        }

        private INewsPostService NewsService { get; }

        /// <summary>
        /// Command para detalhamento de notícias.
        /// </summary>
        public IMvxAsyncCommand<NewsPost> DetailNewsPostCommand { get; private set; }

        /// <summary>
        /// Command para voltar à Home.
        /// </summary>
        public IMvxAsyncCommand HomeCommand { get; private set; }

        private MvxObservableCollection<NewsPost> _news;

        /// <summary>
        /// Notícias a serem exibidas.
        /// </summary>
        public MvxObservableCollection<NewsPost> News
        {
            get { return _news; }
            set { _news = value; }
        }

        /// <summary>
        /// Navega à tela de detalhamento de notícias.
        /// </summary>
        /// <param name="noticia">A notícia a ser detalhada</param>
        private async Task NavigateToNewsDetailAsync(NewsPost noticia) => await NavigationService.Navigate<NewsDetailViewModel, int>(noticia.Id);

        /// <summary>
        /// Navega à Home.
        /// </summary>
        private async Task NavigateToHomeAsync() => await NavigationService.Navigate<HomeViewModel>();

        public override async Task Initialize()
        {
            await base.Initialize();

            News.AddRange(await NewsService.GetAllAsync());
        }

    }
}
