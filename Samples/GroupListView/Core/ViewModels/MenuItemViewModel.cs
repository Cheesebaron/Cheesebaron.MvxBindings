using Cheesebaron.MvxBindings.GroupListView.Interfaces;
using Cirrious.MvvmCross.ViewModels;

namespace Core.ViewModels
{
    public class MenuItemViewModel 
        : MvxViewModel
            , IGroupListViewItem
    {
        private string _title;
        private string _imageUrl;
        private int _badgeCount;

        public MenuItemViewModel(bool isGroupHeader)
        {
            IsGroup = isGroupHeader;
        }

        public bool IsGroup { get; private set; }

        public string Title
        {
            get { return _title; }
            set 
            { 
                _title = value;
                RaisePropertyChanged(() => Title);
            }
        }

        public string ImageUrl
        {
            get { return _imageUrl; }
            set
            {
                _imageUrl = value; 
                RaisePropertyChanged(() => ImageUrl);
            }
        }

        public int BadgeCount
        {
            get { return _badgeCount; }
            set
            {
                _badgeCount = value; 
                RaisePropertyChanged(() => BadgeCount);
            }
        }

        public override string ToString()
        {
            return string.Format("Is Group {0}, Title {1}, BadgeCount {2}, ImageUrl {3}", IsGroup, Title, BadgeCount,
                ImageUrl);
        }
    }
}