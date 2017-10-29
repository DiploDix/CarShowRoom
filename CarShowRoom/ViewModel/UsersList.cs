using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using CarShowRoom.Model;

namespace CarShowRoom.ViewModel
{
    class UsersList : INotifyPropertyChanged
    {
        private static ObservableCollection<User> usersList = new ObservableCollection<User>();

        public ObservableCollection<User> UserList
        {
            get
            {
                return usersList;
            }
            set
            {
                usersList = value;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}