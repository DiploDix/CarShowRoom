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
        private ObservableCollection<Car> car = new ObservableCollection<Car>();
        DefaultLists lists = new DefaultLists();
        private string _usedOrNewCar = "Все";
        private string _stateCar = "Все";
        private string _producerCar = "Все";
        private string _fuelypeCar = "Все";
        private string _transmissionCar = "Все";
        private string _typeCar = "Все";
        private string _regionCar = "Все";
        private string _markCar = "";
        private string _modelCar = "";
        private int _yearMinCar;
        private int _yearMaxCar;
        private int _priceMinCar;
        private int _priceMaxCar;
        private float _engineMinAmount;
        private float _engineMaxAmount;


        public SearchViewModel()
        {
            defCar = cars.CarList;
            SearchEngine();
        }

        public void UpdateSearch()
        {
            SearchEngine();
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
            get => _fuelypeCar;
            set
            {
                _fuelypeCar = value;
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
        public int SetYearMin
        {
            get => _yearMinCar;
            set
            {
                _yearMinCar = value;
                SearchEngine();
            }
        }

        public int SetYearMax
        {
            get => _yearMaxCar;
            set
            {
                _yearMaxCar = value;
                SearchEngine();
            }
        }
        /// <summary>
        /// Цена авто
        /// </summary>
        public int SetPriceMin
        {
            get => _priceMinCar;
            set
            {
                _priceMinCar = value;
                SearchEngine();
            }
        }

        public int SetPriceMax
        {
            get => _priceMaxCar;
            set
            {
                _priceMaxCar = value;
                SearchEngine();
            }
        }

        public float SetEngineAmountMin
        {
            get => _engineMinAmount;
            set
            {
                _engineMinAmount = value;
                SearchEngine();
            }
        }

        public float SetEngineAmountMax
        {
            get => _engineMaxAmount;
            set
            {
                _engineMaxAmount = value;
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
                else if (_markCar.ToLower() != c.MarkCar.ToLower())
                {
                    continue;
                }

                /* Модель авто */
                if (_modelCar == "") { }
                else if (_modelCar.ToLower() != c.ModelCar.ToLower())
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
                if (_yearMinCar == 0 && _yearMaxCar == 0) { }
                else if (_yearMinCar > c.YearCar && _yearMaxCar < c.YearCar)
                {
                    continue;
                }

                /* Цена авто */
                if (_priceMinCar == 0 && _priceMaxCar == 0) { }
                else if (_priceMinCar > c.PriceCar && _priceMaxCar < c.PriceCar)
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
                else if (_usedOrNewCar != c.UsedOrNewCar)
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
                else if (_producerCar != c.ProductionCar)
                {
                    continue;
                }

                if (_fuelypeCar == "Все") { }
                else if (_fuelypeCar != c.FuelCar)
                {
                    continue;
                }

                if (_transmissionCar == "Все") { }
                else if (_transmissionCar != c.TransmissionCar)
                {
                    continue;
                }

                if (_engineMinAmount == 0 && _engineMaxAmount == 0) { }
                else if (_engineMinAmount > c.EngineAmountCar && _engineMinAmount < c.EngineAmountCar)
                {
                    continue;
                }

                car.Add(c);
            }

            OnPropertyChanged("selectGrid");
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
