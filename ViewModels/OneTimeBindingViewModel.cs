using System.Windows.Input;
using WpfLab2.Models;

namespace WpfLab2.ViewModels
{
    public class OneTimeBindingViewModel : ObservableObject
    {
        public Person Person { get; } = new Person();

        public ICommand ChangeNameCommand { get; }

        public OneTimeBindingViewModel()
        {
            ChangeNameCommand = new RelayCommand(() =>
            {
                Person.Name = Person.Name == "Иван" ? "Пётр" : "Иван";
            });
        }
    }
}
