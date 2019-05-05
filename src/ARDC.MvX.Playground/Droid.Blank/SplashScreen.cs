
using Android.App;
using ARDC.MvX.Playground.Core;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace Droid.Blank
{
    [Activity(Label = "@string/app_name", Theme="@style/AppTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashScreen : MvxSplashScreenAppCompatActivity<MvxAppCompatSetup<App>, App>
    {
        public SplashScreen() : base(Resource.Layout.SplashScreen)
        {
        }
    }
}