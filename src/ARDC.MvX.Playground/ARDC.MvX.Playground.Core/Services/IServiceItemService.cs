using ARDC.MvX.Playground.Core.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ARDC.MvX.Playground.Core.Services
{
    /// <summary>
    /// Serviço para interação com 
    /// </summary>
    public interface IServiceItemService
    {
        /// <summary>
        /// Adiciona um novo serviço ao App.
        /// </summary>
        /// <param name="serviceItem">Serviço a ser adicionado</param>
        /// <param name="ct">Token para controle de cancelamento</param>
        Task AddAsync(ServiceItem serviceItem = null, CancellationToken ct = default);

        /// <summary>
        /// Edita um serviço cadastrado no App.
        /// </summary>
        /// <param name="serviceItem">Serviço a ser editado</param>
        /// <param name="ct">Token para controle de cancelamento</param>
        Task EditAsync(ServiceItem serviceItem, CancellationToken ct = default);

        /// <summary>
        /// Recupera todos os serviços cadastrados no App.
        /// </summary>
        /// <param name="ct">Token para controle de cancelamento</param>
        /// <returns>Uma lista contendo is serviços encontrados</returns>
        Task<IList<ServiceItem>> GetAllAsync(CancellationToken ct = default);

        /// <summary>
        /// Recupera um serviço específico no App.
        /// </summary>
        /// <param name="id">ID do serviço a ser buscada</param>
        /// <param name="ct">Token para controle de cancelamento</param>
        /// <returns>O serviço encontrado</returns>
        Task<ServiceItem> GetAsync(int id, CancellationToken ct = default);

        /// <summary>
        /// Remove um serviço do App.
        /// </summary>
        /// <param name="id">ID do serviço a ser removido</param>
        /// <param name="ct">Token para controle de cancelamento</param>
        void RemoveAsync(int id, CancellationToken ct = default);

        /// <summary>
        /// Adiciona um novo serviço ao App.
        /// </summary>
        /// <param name="serviceItem">Serviço a ser adicionado</param>
        void Add(ServiceItem serviceItem = null);

        /// <summary>
        /// Edita um serviço cadastrado no App.
        /// </summary>
        /// <param name="serviceItem">Serviço a ser editado</param>
        void Edit(ServiceItem serviceItem);

        /// <summary>
        /// Recupera todos os serviços cadastrados no App.
        /// </summary>
        /// <returns>Uma lista contendo is serviços encontrados</returns>
        IList<ServiceItem> GetAll();

        /// <summary>
        /// Recupera um serviço específico no App.
        /// </summary>
        /// <param name="id">ID do serviço a ser buscada</param>
        /// <returns>O serviço encontrado</returns>
        ServiceItem Get(int id);

        /// <summary>
        /// Remove um serviço do App.
        /// </summary>
        /// <param name="id">ID do serviço a ser removido</param>
        void Remove(int id);
    }
}
