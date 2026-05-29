using System.Windows;
using System.Windows.Input;
using WpfLab2.Models;

namespace WpfLab2.ViewModels
{
    public class OneWayBindingViewModel : ObservableObject
    {
        public Person Person { get; } = new Person();

        public ICommand ShowEmailCommand { get; }
        public ICommand ResetCommand { get; }

        public OneWayBindingViewModel()
        {
            ShowEmailCommand = new RelayCommand(() =>
            {
                MessageBox.Show($"Текущий Email в ViewModel: {Person.Email}",
                    "OneWayToSource", MessageBoxButton.OK, MessageBoxImage.Information);
            });

            ResetCommand = new RelayCommand(() =>
            {
                Person.Age = 20;
                Person.Email = "ivan@example.com";
            });
        }
    }
}
