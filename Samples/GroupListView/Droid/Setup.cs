using Android.Content;
using Android.Views;
using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;
using Core;

namespace Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) 
            : base(applicationContext)
        { }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override void FillViewTypes(IMvxTypeCache<View> cache)
        {
            base.FillViewTypes(cache);
            cache.AddAssembly(typeof (Cheesebaron.MvxBindings.GroupListView.MvxGroupListView).Assembly);
        }
    }
}