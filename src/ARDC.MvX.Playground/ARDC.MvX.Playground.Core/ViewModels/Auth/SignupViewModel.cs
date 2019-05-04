using ARDC.MvX.Playground.Core.Models;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace ARDC.MvX.Playground.Core.ViewModels.Auth
{
    /// <summary>
    /// ViewModel para Cadastro de novos usuários.
    /// </summary>
    public class SignupViewModel : MvxNavigationViewModel
    {
        public SignupViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            SignUpCommand = new MvxAsyncCommand(SignUp);
        }

        private User _newUser;

        /// <summary>
        /// Usuário a ser cadastrado no App.
        /// </summary>
        public User NewUser
        {
            get { return _newUser; }
            set { SetProperty(ref _newUser, value); }
        }

        /// <summary>
        /// Command para o cadastro.
        /// </summary>
        public IMvxAsyncCommand SignUpCommand { get; private set; }

        /// <summary>
        /// Realiza o cadastro do usuário.
        /// </summary>
        /// <returns></returns>
        private async Task SignUp()
        {
            // TODO: Exibir um toast/dialog
            await NavigationService.Navigate<LoginViewModel>();
        }
    }
}
