using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections;
using System.ComponentModel;
using CarShowRoom.Model;
using System.Collections.ObjectModel;

namespace CarShowRoom.ViewModel
{
    class CarsViewModel : INotifyPropertyChanged
    {
        DefaultLists lists = new DefaultLists();
        ObservableCollection<Car> car = new CarsList().CarList;
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public CarsViewModel() { }


        public ObservableCollection<Car> GetListCar
        {
            get
            {
                return car;
            }
            set
            {
                car = value;
                OnPropertyChanged("carGrid");
            }
        }

        public List<string> GetListAuto
        {
            get
            {
                return lists.ListAuto;
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

        public IEnumerable<string> GetListBodyTypeCars
        {
            get
            {
                return Enum.GetNames(typeof(BodyType));
            }

        }
        public IEnumerable<string> GetListRegionCars
        {
            get
            {
                return Enum.GetNames(typeof(Region));
            }
        }


    }
}