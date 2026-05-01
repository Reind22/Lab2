using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfLab2.Models;

namespace WpfLab2.ViewModels
{
    public partial class OneWayBindingViewModel : ObservableObject
    {
        private Person _person;

        public Person Person
        {
            get
            {
                return _person;
            }
        }

        public OneWayBindingViewModel()
        {
            _person = new Person();
        }

        [RelayCommand]
        private void ShowEmail()
        {
            string message = "Текущий Email в ViewModel: " + Person.Email;
            MessageBox.Show(message, "OneWayToSource", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        [RelayCommand]
        private void Reset()
        {
            Person.Age = 20;
            Person.Email = "ivan@example.com";
        }
    }
}
