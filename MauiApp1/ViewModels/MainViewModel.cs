using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        string text;

        [ObservableProperty]
        ObservableCollection<string> items;

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrEmpty(Text))
                return;

            items.Add(Text);

            Text = String.Empty;
        }

        [RelayCommand]
        void Delete(string item)
        {
            if (items.Contains(item))
            {
                Items.Remove(item);
            }
        }

    }
}
