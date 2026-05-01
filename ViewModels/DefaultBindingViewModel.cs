using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfLab2.Models;

namespace WpfLab2.ViewModels
{
    public partial class DefaultBindingViewModel : ObservableObject
    {
        private Person _person;

        public Person Person
        {
            get
            {
                return _person;
            }
        }

        public DefaultBindingViewModel()
        {
            _person = new Person();
        }

        [RelayCommand]
        private void Reset()
        {
            Person.Name = "Иван";
            Person.Age = 20;
        }

        [RelayCommand]
        private void RandomizeAge()
        {
            Random random = new Random();
            Person.Age = random.Next(18, 80);
        }
    }
}
