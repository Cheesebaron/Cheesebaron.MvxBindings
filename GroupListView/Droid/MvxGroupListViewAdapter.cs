using Android.Content;
using Android.Views;
using Cheesebaron.MvxBindings.GroupListView.Interfaces;
using Cirrious.MvvmCross.Binding.Droid.Views;

namespace Cheesebaron.MvxBindings.GroupListView
{
    public class MvxGroupListViewAdapter 
        : MvxAdapter
    {
        private int _groupTemplateId;

        public MvxGroupListViewAdapter(Context context) 
            : base(context)
        { }

        public int GroupTemplateId
        {
            get { return _groupTemplateId; }
            set
            {
                if (_groupTemplateId == value)
                    return;

                _groupTemplateId = value;

                if (ItemsSource != null)
                    NotifyDataSetChanged();
            }
        }

        protected override View GetBindableView(View convertView, object source, int templateId)
        {
            var item = source as IGroupListViewItem;
            return item == null
                ? base.GetBindableView(convertView, source, templateId)
                : base.GetBindableView(convertView, source, item.IsGroup ? 
                    GroupTemplateId : templateId);
        }
    }
}