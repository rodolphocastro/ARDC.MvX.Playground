using ARDC.MvX.Playground.Core.Services;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Threading.Tasks;

namespace ARDC.MvX.Playground.Core.ViewModels.Auth
{
    /// <summary>
    /// View Model para login no App.
    /// </summary>
    public class LoginViewModel : MvxNavigationViewModel
    {
        public LoginViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, IUserService userService) : base(logProvider, navigationService)
        {
            UserService = userService ?? throw new ArgumentNullException(nameof(userService));

            LoginCommand = new MvxAsyncCommand(LoginAsync);
            ForgotPasswordCommand = new MvxAsyncCommand(NavigateToForgotPassword);
        }

        private IUserService UserService { get; }

        private string _login;

        /// <summary>
        /// Credencial de Login do usuário.
        /// </summary>
        public string Login
        {
            get { return _login; }
            set { SetProperty(ref _login, value); }
        }

        private string _password;

        /// <summary>
        /// Credencial de Senha do usuário.
        /// </summary>
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        /// <summary>
        /// Command para efetuar o Login.
        /// </summary>
        public IMvxAsyncCommand LoginCommand { get; private set; }

        /// <summary>
        /// Command para navegar ao "Esqueci minha Senha".
        /// </summary>
        public IMvxAsyncCommand ForgotPasswordCommand { get; private set; }

        /// <summary>
        /// Realiza o login com base nas credenciais preenchidas.
        /// </summary>
        private async Task LoginAsync()
        {
            bool result = await UserService.LoginAsync(Login, Password);
            //if (result)
            // TODO: Navegar para próxima tela
            //else
            // TODO: Exibir aviso de senha inválida
        }

        /// <summary>
        /// Navega ao ViewModel de "Esqueci minha senha"
        /// </summary>
        private async Task NavigateToForgotPassword()
        {
            // TODO: Implementar
            //await NavigationService.Navigate<ForgotPasswordViewModel>();
            await Task.CompletedTask;
        }

    }
}
