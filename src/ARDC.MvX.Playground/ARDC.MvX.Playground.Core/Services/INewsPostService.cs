using ARDC.MvX.Playground.Core.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ARDC.MvX.Playground.Core.Services
{
    /// <summary>
    /// Serviço para interação com notícias do App.
    /// </summary>
    public interface INewsPostService
    {
        /// <summary>
        /// Obtem todas as noticias cadastradas.
        /// </summary>
        /// <param name="ct">Token para controle de cancelamento</param>
        /// <returns>Uma lista de notícias</returns>
        Task<IList<NewsPost>> GetAllAsync(CancellationToken ct = default);

        /// <summary>
        /// Obtem uma notícia específica
        /// </summary>
        /// <param name="id">ID da noticia a ser buscada</param>
        /// <param name="ct">Token para controle de cancelamento</param>
        /// <returns>A noticia encontrada</returns>
        Task<NewsPost> GetAsync(int id, CancellationToken ct = default);

        /// <summary>
        /// Obtem todas as noticias cadastradas.
        /// </summary>
        /// <returns>Uma lista de notícias</returns>
        IList<NewsPost> GetAll();

        /// <summary>
        /// Obtem uma notícia específica
        /// </summary>
        /// <param name="id">ID da noticia a ser buscada</param>
        /// <returns>A noticia encontrada</returns>
        NewsPost Get(int id);
    }
}
