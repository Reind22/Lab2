using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfLab2.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string _name = "Иван";
        private int _age = 20;
        private string _email = "ivan@example.com";
        private bool _isActive = true;
        private string _role = "Пользователь";

        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        public int Age
        {
            get => _age;
            set => Set(ref _age, value);
        }

        public string Email
        {
            get => _email;
            set => Set(ref _email, value);
        }

        public bool IsActive
        {
            get => _isActive;
            set => Set(ref _isActive, value);
        }

        public string Role
        {
            get => _role;
            set => Set(ref _role, value);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void Set<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (Equals(field, value)) return;
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
