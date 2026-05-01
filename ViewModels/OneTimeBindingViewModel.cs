using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfLab2.Models;

namespace WpfLab2.ViewModels
{
    public partial class OneTimeBindingViewModel : ObservableObject
    {
        private Person _person;

        public Person Person
        {
            get
            {
                return _person;
            }
        }

        public OneTimeBindingViewModel()
        {
            _person = new Person();
        }

        [RelayCommand]
        private void ChangeName()
        {
            if (Person.Name == "Иван")
            {
                Person.Name = "Пётр";
            }
            else
            {
                Person.Name = "Иван";
            }
        }
    }
}
