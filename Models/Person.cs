using WpfLab2.ViewModels;

namespace WpfLab2.Models
{
    public class Person : ObservableObject
    {
        private string _name = "Иван";
        private int _age = 20;
        private string _email = "ivan@example.com";
        private bool _isActive = true;
        private string _role = "Пользователь";

        public string Name { get => _name; set => SetProperty(ref _name, value); }
        public int Age { get => _age; set => SetProperty(ref _age, value); }
        public string Email { get => _email; set => SetProperty(ref _email, value); }
        public bool IsActive { get => _isActive; set => SetProperty(ref _isActive, value); }
        public string Role { get => _role; set => SetProperty(ref _role, value); }
    }
}
