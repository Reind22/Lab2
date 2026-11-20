using System.Windows;
using System.Windows.Input;
using WpfLab2.Models;

namespace WpfLab2.ViewModels
{
    public class OneWayBindingViewModel : ObservableObject
    {
        private Person _person;

        public Person Person
        {
            get
            {
                return _person;
            }
        }

        public ICommand ShowEmailCommand { get; private set; }
        public ICommand ResetCommand { get; private set; }

        public OneWayBindingViewModel()
        {
            _person = new Person();
            ShowEmailCommand = new RelayCommand(ShowEmail);
            ResetCommand = new RelayCommand(Reset);
        }

        private void ShowEmail()
        {
            string message = "Текущий Email в ViewModel: " + Person.Email;
            MessageBox.Show(message, "OneWayToSource", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Reset()
        {
            Person.Age = 20;
            Person.Email = "ivan@example.com";
        }
    }
}
