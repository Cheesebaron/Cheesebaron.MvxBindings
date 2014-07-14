using System.Collections.ObjectModel;
using Core.ViewModels;

namespace Core.Services
{
    public interface IGenerateRandomCrapService
    {
        ObservableCollection<MenuItemViewModel> GenerateRandomMenu(int headersToGenerate = 10);
    }
}
