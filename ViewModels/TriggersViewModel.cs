using WpfLab2.Models;

namespace WpfLab2.ViewModels
{
    public class TriggersViewModel : ObservableObject
    {
        public Person Person { get; }

        public bool IsAdultAndActive => Person.IsActive && Person.Age >= 18;

        public TriggersViewModel()
        {
            Person = new Person();
            Person.PropertyChanged += (_, e) =>
            {
                if (e.PropertyName == nameof(Person.Age) || e.PropertyName == nameof(Person.IsActive))
                    OnPropertyChanged(nameof(IsAdultAndActive));
            };
        }
    }
}
