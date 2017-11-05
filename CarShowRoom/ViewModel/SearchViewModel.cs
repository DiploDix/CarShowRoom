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
    class SearchViewModel : INotifyPropertyChanged
    {
        CarsList cars = new CarsList();
        ObservableCollection<Car> car = new ObservableCollection<Car>();
        public SearchViewModel()
        {

            car = cars.CarList;
        }

        public string CategoryComboBox
        {
            get
            {
                return "sdd";
            }
            set
            {

            }
        }
        public ObservableCollection<Car> GetListCar
        {
            get
            {
                return car;
            }
        }

        public ObservableCollection<Car> SearchCar()
        {
            ObservableCollection<Car> newCar = new ObservableCollection<Car>();
            newCar = cars.CarList;

            newCar.Where((x) =>
            {
                return x.
            });
        }

        /* */
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
