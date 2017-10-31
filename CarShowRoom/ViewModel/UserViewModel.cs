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
    /* Users.xaml */
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

        public IEnumerable<string> GetListAuto
        {
            get
            {
                return Enum.GetNames(typeof(Auto));
            }
        }

        public IEnumerable<string> GetListState
        {
            get
            {
                return Enum.GetNames(typeof(State));
            }
        }

        public IEnumerable<string> GetListAbroad
        {
            get
            {
                return Enum.GetNames(typeof(Abroad));
            }
        }
        public IEnumerable<string> GetListEngineType
        {
            get
            {
                return Enum.GetNames(typeof(EngineType));
            }

        }

        public IEnumerable<string> GetListTransmission
        {
            get
            {
                return Enum.GetNames(typeof(Transmission));
            }

        }

        public IEnumerable<string> GetListBodyType
        {
            get
            {
                return Enum.GetNames(typeof(BodyType));
            }

        }
        public IEnumerable<string> GetListRegion
        {
            get
            {
                return Enum.GetNames(typeof(Region));
            }

        }
    }
}