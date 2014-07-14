using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Core.ViewModels;

namespace Core.Services
{
    public class GenerateRandomCrapService 
        : IGenerateRandomCrapService
    {
        private readonly List<string> _imageUrls = new List<string>
        {
            "http://critterbabies.com/wp-content/gallery/kittens/803864926_1375572583.jpg",
            "http://critterbabies.com/wp-content/gallery/kittens/happy-kitten-kittens-5890512-1600-1200.jpg",
            "http://uhaweb.hartford.edu/aschmidt/kitten6.jpg",
            "http://r.ddmcdn.com/w_622/u_0/gif/10-kitten-cuteness-1.jpg"

        };

        private readonly Random _random = new Random();

        public ObservableCollection<MenuItemViewModel> GenerateRandomMenu(int headersToGenerate = 10)
        {
            var returnValue = new ObservableCollection<MenuItemViewModel>();
            for (var i = 0; i < headersToGenerate; i++)
            {
                returnValue.Add(new MenuItemViewModel(true)
                {
                    Title = GetRandomString(20)
                });

                var itemsToGenerate = _random.Next(1, 5);
                for (var j = 0; j < itemsToGenerate; j++)
                {
                    returnValue.Add(new MenuItemViewModel(false)
                    {
                        BadgeCount = _random.Next(0, 20),
                        Title = GetRandomString(15),
                        ImageUrl = _imageUrls[_random.Next(0, _imageUrls.Count - 1)]
                    });
                }
            }
            return returnValue;
        }

        public static string GetRandomString(int length)
        {
            var r = new Random();
            return new String(Enumerable.Range(0, length).Select(n => (Char)(r.Next(32, 127))).ToArray());
        }
    }
}
