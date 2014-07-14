using Android.App;
using Cirrious.MvvmCross.Droid.Views;

namespace Droid
{
    [Activity(Label = "GroupListView Sample", MainLauncher = true, NoHistory = true)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}