using System.ComponentModel;
using System.Runtime.CompilerServices;

using KeLi.FormMvc.App.Properties;

namespace KeLi.FormMvc.App.Models
{
    public class PersonModel : INotifyPropertyChanged
    {
        private string _id;

        private string _name;

        public PersonModel(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id
        {
            get => _id;

            set
            {
                _id = value;

                OnPropertyChanged(nameof(Id));
            }
        }

        public string Name
        {
            get => _name;

            set
            {
                _name = value;

                OnPropertyChanged(nameof(Name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}