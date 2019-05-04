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
    /// ViewModel para Esqueci Minha Senha.
    /// </summary>
    public class ForgotPasswordViewModel : MvxNavigationViewModel
    {
        public ForgotPasswordViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, IUserService userService) : base(logProvider, navigationService)
        {
            UserService = userService ?? throw new ArgumentNullException(nameof(userService));

            ForgotPasswordCommand = new MvxAsyncCommand(ForgotPassword);
        }

        private IUserService UserService { get; }

        private string _login;

        /// <summary>
        /// Login a ter a senha recuperada.
        /// </summary>
        public string Login
        {
            get { return _login; }
            set { SetProperty(ref _login, value); }
        }

        /// <summary>
        /// Command para recuperar a senha.
        /// </summary>
        public IMvxAsyncCommand ForgotPasswordCommand { get; private set; }

        /// <summary>
        /// Realiza a recuperação de senha do usuário.
        /// </summary>
        private async Task ForgotPassword()
        {
            bool result = await UserService.ForgotPasswordAsync(Login);
            if (result)
                await NavigationService.Navigate<LoginViewModel>(); // TODO: Exibir um Toast antes de redirecionar
            //else
                // TODO: Exibir notificação de erro
        }
    }
}
