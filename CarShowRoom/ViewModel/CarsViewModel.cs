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
        CarsList car = new CarsList();
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public CarsViewModel()
        {

        }

        public ObservableCollection<Car> GetListCar
        {
            get
            {
                return car.CarList;
            }
            set
            {
                car.CarList = value;
                OnPropertyChanged("carGrid");
            }
        }

        public IEnumerable<string> GetListAuto
        {
            get
            {
                return Enum.GetNames(typeof(Car.Auto));
            }
        }


    }
}