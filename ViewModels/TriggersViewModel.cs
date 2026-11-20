using System.ComponentModel;
using WpfLab2.Models;

namespace WpfLab2.ViewModels
{
    public class TriggersViewModel : ObservableObject
    {
        private Person _person;

        public Person Person
        {
            get
            {
                return _person;
            }
        }

        public bool IsAdultAndActive
        {
            get
            {
                return Person.IsActive && Person.Age >= 18;
            }
        }

        public TriggersViewModel()
        {
            _person = new Person();
            _person.PropertyChanged += Person_PropertyChanged;
        }

        private void Person_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Age" || e.PropertyName == "IsActive")
            {
                OnPropertyChanged("IsAdultAndActive");
            }
        }
    }
}
