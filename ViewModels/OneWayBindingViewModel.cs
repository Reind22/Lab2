using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfLab2.Models;

namespace WpfLab2.ViewModels
{
    public partial class OneWayBindingViewModel : ObservableObject
    {
        public Person Person { get; } = new Person();

        [RelayCommand]
        private void ShowEmail()
        {
            MessageBox.Show($"Текущий Email в ViewModel: {Person.Email}",
                "OneWayToSource", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        [RelayCommand]
        private void Reset()
        {
            Person.Age = 20;
            Person.Email = "ivan@example.com";
        }
    }
}
