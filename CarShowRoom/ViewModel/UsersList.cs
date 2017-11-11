using System.Collections.ObjectModel;
using CarShowRoom.Model;

namespace CarShowRoom.ViewModel
{
    class UsersList
    {
        /* Главная коллекция */
        private static ObservableCollection<User> usersList = new ObservableCollection<User>();

        /* Свойство для получение колекции userList */
        public ObservableCollection<User> UserList
        {
            get => usersList;
            set => usersList = value;
        }

    }
}