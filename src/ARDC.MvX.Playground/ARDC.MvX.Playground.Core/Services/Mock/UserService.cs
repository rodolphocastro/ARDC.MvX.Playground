using ARDC.MvX.Playground.Core.Generators;
using ARDC.MvX.Playground.Core.Models;
using System.Threading;
using System.Threading.Tasks;

namespace ARDC.MvX.Playground.Core.Services.Mock
{
    public class UserService : IUserService
    {
        public User CurrentUser { get; private set; }

        public bool IsAuthenticated => CurrentUser != null;

        public bool ForgotPassword(string login)
        {
            return true;
        }

        public Task<bool> ForgotPasswordAsync(string login, CancellationToken ct)
        {
            return Task.FromResult(true);
        }

        public bool Login(string login, string password)
        {
            CurrentUser = UserGenerator.GenerateUser();
            return true;
        }

        public Task<bool> LoginAsync(string login, string password, CancellationToken ct)
        {
            CurrentUser = UserGenerator.GenerateUser();
            return Task.FromResult(true);
        }

        public bool Logout()
        {
            CurrentUser = null;
            return true;
        }

        public Task<bool> LogoutAsync(CancellationToken ct)
        {
            CurrentUser = null;
            return Task.FromResult(true);
        }
    }
}
