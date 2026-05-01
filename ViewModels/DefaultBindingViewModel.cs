using System;
using System.Windows.Input;
using WpfLab2.Models;

namespace WpfLab2.ViewModels
{
    public class DefaultBindingViewModel : ObservableObject
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
        public ICommand RandomizeAgeCommand { get; private set; }

        public DefaultBindingViewModel()
        {
            _person = new Person();
            ResetCommand = new RelayCommand(Reset);
            RandomizeAgeCommand = new RelayCommand(RandomizeAge);
        }

        private void Reset()
        {
            Person.Name = "Иван";
            Person.Age = 20;
        }

        private void RandomizeAge()
        {
            Random random = new Random();
            Person.Age = random.Next(18, 80);
        }
    }
}
