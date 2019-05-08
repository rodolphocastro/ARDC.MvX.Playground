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
    /// <summary>
    /// ViewModel para o detalhamento de notícias.
    /// </summary>
    public class NewsDetailViewModel : MvxNavigationViewModel<int>
    {
        public NewsDetailViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, INewsPostService newsPostService) : base(logProvider, navigationService)
        {
            NewsService = newsPostService ?? throw new ArgumentNullException(nameof(newsPostService));

            ListCommand = new MvxAsyncCommand(NavigateToListAsync);
        }

        /// <summary>
        /// Command para retornar à lista de notícias.
        /// </summary>
        public IMvxAsyncCommand ListCommand { get; private set; }


        private NewsPost _news;

        /// <summary>
        /// Notícia sendo detalhada.
        /// </summary>
        public NewsPost News
        {
            get { return _news; }
            set { SetProperty(ref _news, value); }
        }

        /// <summary>
        /// ID da notícia a ser detalhada
        /// </summary>
        private int newsId;

        private INewsPostService NewsService { get; }

        public override void Prepare(int parameter)
        {
            newsId = parameter;
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            News = await NewsService.GetAsync(newsId);
        }

        /// <summary>
        /// Navega à lista de notícias.
        /// </summary>
        private async Task NavigateToListAsync() => await NavigationService.Navigate<NewsListViewModel>();
    }
}
