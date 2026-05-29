using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfLab2.Models;

namespace WpfLab2.ViewModels
{
    public partial class DefaultBindingViewModel : ObservableObject
    {
        public Person Person { get; } = new Person();

        [RelayCommand]
        private void Reset()
        {
            Person.Name = "Иван";
            Person.Age = 20;
        }

        [RelayCommand]
        private void RandomizeAge()
        {
            Person.Age = new System.Random().Next(18, 80);
        }
    }
}
