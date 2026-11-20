using System.Windows.Input;
using WpfLab2.Models;

namespace WpfLab2.ViewModels
{
    public class TwoWayBindingViewModel : ObservableObject
    {
        private Person _person;

        public Person Person
        {
            get
            {
                return _person;
            }
        }

        public ICommand ResetCommand { get; private set; }

        public TwoWayBindingViewModel()
        {
            _person = new Person();
            ResetCommand = new RelayCommand(Reset);
        }

        private void Reset()
        {
            Person.Name = "Иван";
            Person.Email = "ivan@example.com";
            Person.Age = 20;
            Person.IsActive = true;
        }
    }
}
