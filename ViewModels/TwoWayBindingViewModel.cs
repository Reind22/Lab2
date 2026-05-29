using System.Windows.Input;
using WpfLab2.Models;

namespace WpfLab2.ViewModels
{
    public class TwoWayBindingViewModel : ObservableObject
    {
        public Person Person { get; } = new Person();

        public ICommand ResetCommand { get; }

        public TwoWayBindingViewModel()
        {
            ResetCommand = new RelayCommand(() =>
            {
                Person.Name = "Иван";
                Person.Email = "ivan@example.com";
                Person.Age = 20;
                Person.IsActive = true;
            });
        }
    }
}
