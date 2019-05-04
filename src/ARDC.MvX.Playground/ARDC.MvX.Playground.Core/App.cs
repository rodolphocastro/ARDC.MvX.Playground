using ARDC.MvX.Playground.Core.Services.Mock;
using ARDC.MvX.Playground.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using System.Reflection;

namespace ARDC.MvX.Playground.Core
{
    /// <summary>
    /// App em si, classe responsável por realizar as inicializações.
    /// </summary>
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            // Cadastrando todos os serviços no namespace de Mock como interfaces
            CreatableTypes(Assembly.GetAssembly(typeof(UserService)))
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            // Definindo a primeira tela como a Home
            RegisterAppStart<HomeViewModel>();
        }
    }
}
