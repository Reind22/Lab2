using System.Windows.Input;
using WpfLab2.Models;

namespace WpfLab2.ViewModels
{
    public class DefaultBindingViewModel : ObservableObject
    {
        public Person Person { get; } = new Person();

        public ICommand ResetCommand { get; }
        public ICommand RandomizeAgeCommand { get; }

        public DefaultBindingViewModel()
        {
            ResetCommand = new RelayCommand(() =>
            {
                Person.Name = "Иван";
                Person.Age = 20;
            });

            RandomizeAgeCommand = new RelayCommand(() =>
            {
                Person.Age = new System.Random().Next(18, 80);
            });
        }
    }
}
