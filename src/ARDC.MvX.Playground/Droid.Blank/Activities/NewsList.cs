
using Android.App;
using Android.OS;
using ARDC.MvX.Playground.Core.ViewModels.News;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace Droid.Blank.Activities
{
    [Activity(Label = "Notícias")]
    public class NewsList : MvxAppCompatActivity<NewsListViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.NewsList);
        }
    }
}