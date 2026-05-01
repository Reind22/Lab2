using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfLab2.Models;

namespace WpfLab2.ViewModels
{
    public partial class TwoWayBindingViewModel : ObservableObject
    {
        private Person _person;

        public Person Person
        {
            get
            {
                return _person;
            }
        }

        public TwoWayBindingViewModel()
        {
            _person = new Person();
        }

        [RelayCommand]
        private void Reset()
        {
            Person.Name = "Иван";
            Person.Email = "ivan@example.com";
            Person.Age = 20;
            Person.IsActive = true;
        }
    }
}
