
using Android.App;
using Android.OS;
using ARDC.MvX.Playground.Core.ViewModels.Auth;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace Droid.Blank.Activities
{
    [Activity(Label = "Recuperação de Senha")]
    public class ForgotPassword : MvxAppCompatActivity<ForgotPasswordViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ForgotPassword);
        }
    }
}