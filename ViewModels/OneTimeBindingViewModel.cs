using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfLab2.Models;

namespace WpfLab2.ViewModels
{
    public partial class OneTimeBindingViewModel : ObservableObject
    {
        public Person Person { get; } = new Person();

        [RelayCommand]
        private void ChangeName()
        {
            Person.Name = Person.Name == "Иван" ? "Пётр" : "Иван";
        }
    }
}
