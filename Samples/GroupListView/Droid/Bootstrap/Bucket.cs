using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Cirrious.CrossCore.Plugins;

namespace Droid.Bootstrap
{
    public class Bucket
    {
        public class MvxDownloadCachePluingBootstrap
            : MvxPluginBootstrapAction<Cirrious.MvvmCross.Plugins.DownloadCache.PluginLoader>
        { }

        public class MvxFilePluginBootstrap
            : MvxPluginBootstrapAction<Cirrious.MvvmCross.Plugins.File.PluginLoader>
        { }
    }
}