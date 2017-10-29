using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CarShowRoom.Model;
namespace CarShowRoom.ViewModel
{
    class UserViewModel : INotifyPropertyChanged
    {
        UsersList user = new UsersList();
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public UserViewModel()
        {

        }

        public ObservableCollection<User> GetListUser
        {
            get
            {
                return user.UserList;
            }
            set
            {
                user.UserList = value;
                OnPropertyChanged("userGrid");
            }
        }
    }
}