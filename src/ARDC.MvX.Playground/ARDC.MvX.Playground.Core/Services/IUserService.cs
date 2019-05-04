using ARDC.MvX.Playground.Core.Models;
using System.Threading;
using System.Threading.Tasks;

namespace ARDC.MvX.Playground.Core.Services
{
    /// <summary>
    /// Serviço para autenticação e autorização do App.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Usuário atualmente autenticado.
        /// </summary>
        User CurrentUser { get; }

        /// <summary>
        /// Flag indicando se o App está autenticado para uso.
        /// </summary>
        bool IsAuthenticated { get; }

        /// <summary>
        /// Realiza o login do Usuário.
        /// </summary>
        /// <param name="login">Credencial de login</param>
        /// <param name="password">Credencial de senha</param>
        /// <param name="ct">Token para controle de cancelamento</param>
        /// <returns>bool indicando se a operação teve êxito</returns>
        Task<bool> LoginAsync(string login, string password, CancellationToken ct = default);

        /// <summary>
        /// Realiza o logout do Usuário.
        /// </summary>
        /// <param name="ct">Token para controle de cancelamento</param>
        /// <returns>bool indicando se a operação teve êxito</returns>
        Task<bool> LogoutAsync(CancellationToken ct = default);

        /// <summary>
        /// Realiza a recuperação de senha do Usuário.
        /// </summary>
        /// <param name="login">Credencial de login</param>
        /// <param name="ct">Token para controle de cancelamento</param>
        /// <returns>bool indicando se a operação teve êxito</returns>
        Task<bool> ForgotPasswordAsync(string login, CancellationToken ct = default);

        /// <summary>
        /// Realiza o login do Usuário.
        /// </summary>
        /// <param name="login">Credencial de login</param>
        /// <param name="password">Credencial de senha</param>
        /// <returns>bool indicando se a operação teve êxito</returns>
        bool Login(string login, string password);

        /// <summary>
        /// Realiza o logout do Usuário.
        /// </summary>
        /// <returns>bool indicando se a operação teve êxito</returns>
        bool Logout();

        /// <summary>
        /// Realiza a recuperação de senha do Usuário.
        /// </summary>
        /// <param name="login">Credencial de login</param>
        /// <returns>bool indicando se a operação teve êxito</returns>
        bool ForgotPassword(string login);

    }
}
