using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;
using Core.ViewModels;

namespace Droid.Views
{
    [Activity(Label = "GroupListView Sample")]
    public class HomeView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
        }

        public new HomeViewModel ViewModel
        {
            get { return (HomeViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }
    }
}