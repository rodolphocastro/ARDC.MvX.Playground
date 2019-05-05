
using Android.App;
using Android.OS;
using ARDC.MvX.Playground.Core.ViewModels.Landing;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace Droid.Blank.Activities
{
    [Activity(Label = "Landing")]
    public class Landing : MvxAppCompatActivity<LandingViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Landing);
        }
    }
}