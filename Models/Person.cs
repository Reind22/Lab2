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

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (_age != value)
                {
                    _age = value;
                    OnPropertyChanged("Age");
                }
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        public bool IsActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                if (_isActive != value)
                {
                    _isActive = value;
                    OnPropertyChanged("IsActive");
                }
            }
        }

        public string Role
        {
            get
            {
                return _role;
            }
            set
            {
                if (_role != value)
                {
                    _role = value;
                    OnPropertyChanged("Role");
                }
            }
        }
    }
}
