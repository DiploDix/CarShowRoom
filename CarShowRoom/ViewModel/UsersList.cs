using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using CarShowRoom.Model;

namespace CarShowRoom.ViewModel
{
    class UsersList 
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
       
    }
}