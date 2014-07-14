using System.Collections.ObjectModel;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;
using Core.Services;

namespace Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        private ObservableCollection<MenuItemViewModel> _menuItems;

        public HomeViewModel(IGenerateRandomCrapService service)
        {
            MenuItems = service.GenerateRandomMenu();
        }

        public ObservableCollection<MenuItemViewModel> MenuItems
        {
            get { return _menuItems; }
            set
            {
                _menuItems = value;
                RaisePropertyChanged(() => MenuItems);
            }
        }

        public ICommand ClickCommand
        {
            get
            {
                return new MvxCommand<MenuItemViewModel>(item => System.Diagnostics.Debug.WriteLine(item));
            }
        }
    }
}
