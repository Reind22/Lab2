using System.Windows.Input;
using WpfLab2.Models;

namespace WpfLab2.ViewModels
{
    public class OneTimeBindingViewModel : ObservableObject
    {
        private Person _person;

        public Person Person
        {
            get
            {
                return _person;
            }
        }

        public ICommand ChangeNameCommand { get; private set; }

        public OneTimeBindingViewModel()
        {
            _person = new Person();
            ChangeNameCommand = new RelayCommand(ChangeName);
        }

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
