using System.Windows.Input;
using Android.Content;
using Android.Util;
using Cheesebaron.MvxBindings.GroupListView.Interfaces;
using Cirrious.MvvmCross.Binding.Droid.ResourceHelpers;
using Cirrious.MvvmCross.Binding.Droid.Views;
using Java.Net;

namespace Cheesebaron.MvxBindings.GroupListView
{
    public class MvxGroupListView : MvxListView
    {
        public MvxGroupListView(Context context, IAttributeSet attrs) 
            : this(context, attrs, new MvxGroupListViewAdapter(context))
        { }

        public MvxGroupListView(Context context, IAttributeSet attrs, MvxGroupListViewAdapter adapter) 
            : base(context, attrs, adapter)
        {
            var typedArray = context.ObtainStyledAttributes(attrs, Resource.Styleable.MvxGroupListView);
            var groupTemplateId = typedArray.GetResourceId(Resource.Styleable.MvxGroupListView_GroupTemplate, -1);
            typedArray.Recycle();

            adapter.GroupTemplateId = groupTemplateId;
        }

        public ICommand GroupClick { get; set; }

        protected override void ExecuteCommandOnItem(ICommand command, int position)
        {
            var rawItem = Adapter.GetRawItem(position);
            if (rawItem == null)
                return;

            var item = rawItem as IGroupListViewItem;
            if (item != null)
                if (item.IsGroup)
                    command = GroupClick;

            if (command == null)
                return;

            if (!command.CanExecute(rawItem))
                return;

            command.Execute(rawItem);
        }
    }
}
