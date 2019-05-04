using ARDC.MvX.Playground.Core.ViewModels.Landing;
using MvvmCross.ViewModels;

namespace ARDC.MvX.Playground.Core
{
    /// <summary>
    /// App em si, classe responsável por realizar as inicializações.
    /// </summary>
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            // TODO: Adicionar Inicialização
            RegisterAppStart<LandingViewModel>();
        }
    }
}
