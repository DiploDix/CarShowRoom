using System.Collections.ObjectModel;
using System.ComponentModel;
using CarShowRoom.Model;
namespace CarShowRoom.ViewModel
{
    /* Users.xaml */
    class UserViewModel : INotifyPropertyChanged
    {
        UsersList user = new UsersList();

        public UserViewModel() { }

        /* Выводим коллекцию пользователей в datagridview */
        public ObservableCollection<User> GetListUser
        {
            get => user.UserList;
            set
            {
                user.UserList = value;
                OnPropertyChanged("userGrid");
            }
        }

        /* Событие изменения свойства */
        public event PropertyChangedEventHandler PropertyChanged;
        
        /* Метод изменения свойства */
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}