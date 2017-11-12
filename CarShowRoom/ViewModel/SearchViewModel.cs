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
        ObservableCollection<Car> defCar;
        public static ObservableCollection<Car> car = new ObservableCollection<Car>();
        DefaultLists lists = new DefaultLists();
        string _usedOrNewCar = "Все";
        string _stateCar = "Все";
        string _producerCar = "Все";
        string _engineTypeCar = "Все";
        string _transmissionCar = "Все";
        string _typeCar = "Все";
        string _regionCar = "Все";
        string _markCar = "";
        string _modelCar = "";
        int _yearCar = 0;
        int _priceCar = 0;
        float _engineAmount = 0.0f;


        public SearchViewModel()
        {
            defCar = cars.CarList;
            SearchEngine();
        }

        public void DisplayDefaultCollection()
        {
            _usedOrNewCar = "Все";
            _stateCar = "Все";
            _producerCar = "Все";
            _engineTypeCar = "Все";
            _transmissionCar = "Все";
            _typeCar = "Все";
            _regionCar = "Все";
            _modelCar = "";
            _markCar = "";
        }

        /// <summary>
        /// Производитель авто
        /// </summary>
        public string SetProducer
        {
            get => _producerCar; set
            {
                _producerCar = value;
                SearchEngine();
            }
        }

        /// <summary>
        /// Состояние авто
        /// </summary>
        public string SetState
        {
            get => _stateCar;
            set
            {
                _stateCar = value;
                SearchEngine();
            }
        }

        /// <summary>
        /// Поиск авто
        /// </summary>
        public string SetUsedOrNew
        {
            get => _usedOrNewCar;
            set
            {
                _usedOrNewCar = value;
                SearchEngine();
            }
        }
        /// <summary>
        /// Тип двигателя
        /// </summary>
        public string SetEngineType
        {
            get => _engineTypeCar;
            set
            {
                _engineTypeCar = value;
                SearchEngine();
            }
        }
        /// <summary>
        /// Тип трансмиссии
        /// </summary>
        public string SetTransmission
        {
            get => _transmissionCar;
            set
            {
                _transmissionCar = value;
                SearchEngine();
            }
        }
        /// <summary>
        /// Тип кузова
        /// </summary>
        public string SetBodyType
        {
            get => _typeCar;
            set
            {
                _typeCar = value;
                SearchEngine();
            }
        }
        /// <summary>
        /// Область 
        /// </summary>
        public string SetRegion
        {
            get => _regionCar;
            set
            {
                _regionCar = value;
                SearchEngine();
            }
        }
        /// <summary>
        /// Марка авто
        /// </summary>
        public string SetMark
        {
            get => _markCar;
            set
            {
                _markCar = value;
                SearchEngine();
            }
        }
        /// <summary>
        /// Модель авто
        /// </summary>
        public string SetModel
        {
            get => _modelCar;
            set
            {
                _modelCar = value;
                SearchEngine();
            }
        }
        /// <summary>
        /// Год авто
        /// </summary>
        public int SetYear
        {
            get => _yearCar;
            set
            {
                _yearCar = value;
                SearchEngine();
            }
        }
        /// <summary>
        /// Цена авто
        /// </summary>
        public int SetPrice
        {
            get => _priceCar;
            set
            {
                _priceCar = value;
                SearchEngine();
            }
        }

        public float SetEngineAmount
        {
            get => _engineAmount;
            set
            {
                _engineAmount = value;
                SearchEngine();
            }
        }
        void SearchEngine()
        {
            if (car != null)
                car.Clear();
            foreach (Car c in defCar)
            {
                /* Марка авто */
                if (_markCar == "") { }
                else if (_markCar != c.MarkCar)
                {
                    continue;
                }

                /* Модель авто */
                if (_modelCar == "") { }
                else if (_modelCar != c.ModelCar)
                {
                    continue;
                }

                /* Тип авто */
                if (_typeCar == "Все") { }
                else if (_typeCar != c.BodyTypeCar)
                {
                    continue;
                }

                /* Год авто */
                if (_yearCar == 0) { }
                else if (_yearCar != c.YearCar)
                {
                    continue;
                }

                /* Цена авто */
                if (_priceCar == 0) { }
                else if (_priceCar != c.PriceCar)
                {
                    continue;
                }

                /* Область авто */
                if (_regionCar == "Все") { }
                else if (_regionCar != c.RegionCar)
                {
                    continue;
                }

                /* Производитель авто */
                if (_usedOrNewCar == "Все") { }
                else if (_usedOrNewCar != c.HowCar)
                {
                    continue;
                }

                /* Состояние авто */
                if (_stateCar == "Все") { }
                else if (_stateCar != c.StateCar)
                {
                    continue;
                }

                /* Марка авто */
                if (_producerCar == "Все") { }
                else if (_producerCar != c.AbroadCar)
                {
                    continue;
                }

                if (_engineTypeCar == "Все") { }
                else if (_engineTypeCar != c.EngineTypeCar)
                {
                    continue;
                }

                if (_transmissionCar == "Все") { }
                else if (_transmissionCar != c.TransmissionCar)
                {
                    continue;
                }

                if (_engineAmount == 0) { }
                else if (_engineAmount != c.EngineAmountCar)
                {
                    continue;
                }

                car.Add(c);
            }

            OnPropertyChanged("searchGrid");
        }

        public ObservableCollection<Car> GetListCar
        {
            get
            {
                return car;
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
