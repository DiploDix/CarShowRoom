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
        string _auto = "";
        string _state = "";
        string _abroad = "";
        string _engineType = "";
        string _transmission = "";
        string _typeCar = "";
        string _regionCar = "";

        List<string> getListAuto = new List<string>(new string[] { "----", "Новое", "Старое" });
        List<string> getListState = new List<string>(new string[] { "----", "Отличное", "Хорошее", "Нормальное", "Удовлетворительно", "Ужасно" });
        List<string> getListAbroad = new List<string>(new string[] { "----", "Отечественные", "Зарубежные" });
        List<string> getListEngineType = new List<string>(new string[] { "----", "Бензин", "Дизель", "Электро", "Гибрид", "Газ" });
        List<string> getListTransmission = new List<string>(new string[] { "----", "Гибрид", "Механика","Типтроник","","", });
        List<string> getListBodyTypeCars = new List<string>(new string[] { "----", "Новое", "Старое" });
        List<string> getListRegionCars = new List<string>(new string[] { "----", "Новое", "Старое" });

        CarsList cars = new CarsList();
        ObservableCollection<Car> car;

        public SearchViewModel()
        {
            car = cars.CarList;
        }

        public void DisplayDefaultCollection()
        {
            //car = cars.CarList;
            _auto = "";
            _state = "";
            _abroad = "";
            _engineType = "";
            _transmission = "";
            _typeCar = "";
            _regionCar = "";
        }

        public ObservableCollection<Car> GetListCar
        {
            get
            {
                return car;
            }
        }

        string _d = "lolk";

        public string AutoSearch
        {
            get
            {
                return _d;
            }
            set
            {
                _d = value;
                OnPropertyChanged("t1");
            }
        }

        public List<string> GetListAuto
        {
            get
            {
                return getListAuto;
            }

        }

        /* public List<string> GetListAuto
         {
             get
             {
                 return getListAuto;
             }

             set
             {

                 OnPropertyChanged("ttt");

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
         */
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
