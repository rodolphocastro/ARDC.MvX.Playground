
using Android.App;
using Android.OS;
using ARDC.MvX.Playground.Core.ViewModels.Auth;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace Droid.Blank.Activities
{
    [Activity(Label = "Cadastro")]
    public class Signup : MvxAppCompatActivity<SignupViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Signup);
        }
    }
}