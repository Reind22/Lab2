using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfLab2.Models
{
    public partial class Person : ObservableObject
    {
        [ObservableProperty]
        private string name = "Иван";

        [ObservableProperty]
        private int age = 20;

        [ObservableProperty]
        private string email = "ivan@example.com";

        [ObservableProperty]
        private bool isActive = true;

        [ObservableProperty]
        private string role = "Пользователь";
    }
}
