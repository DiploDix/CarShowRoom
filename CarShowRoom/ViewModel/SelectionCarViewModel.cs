using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarShowRoom.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CarShowRoom.ViewModel
{
    class SelectionCarViewModel : INotifyPropertyChanged
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


        public SelectionCarViewModel()
        {
            defCar = cars.CarList;
        }

        public void SelectionCar(User u)
        {
            _usedOrNewCar = u.UsedOrNewUser;
            _stateCar = u.StateUser;
            _producerCar = u.ProductionUser;
            _fuelypeCar = u.FuelUser;
            _transmissionCar = u.TransmissionUser;
            _typeCar = u.BodyTypeUser;
            _regionCar = u.RegionUser;
            _markCar = String.IsNullOrEmpty(u.MarkUser) ? "" : u.MarkUser;
            _modelCar = String.IsNullOrEmpty(u.ModelUser) ? "" : u.ModelUser; ;
            _yearMinCar = u.YearMaxUser;
            _yearMaxCar = u.YearMaxUser;
            _priceMinCar = u.PriceMinUser;
            _priceMaxCar = u.PriceMaxUser;
            _engineMinAmount = u.EngineAmountMinUser;
            _engineMaxAmount = u.EngineAmountMaxUser;

            SearchEngine();
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
                else if (_yearMinCar <= c.YearCar && _yearMaxCar == 0) { }
                else if (_yearMinCar == 0 && _yearMaxCar >= c.YearCar) { }
                else if (_yearMinCar <= c.YearCar && _yearMaxCar >= c.YearCar) { }
                else
                    continue;

                /* Цена авто */
                if (_priceMinCar == 0 && _priceMaxCar == 0) { }
                else if (_priceMinCar <= c.PriceCar && _priceMaxCar == 0) { }
                else if (_priceMinCar == 0 && _priceMaxCar >= c.PriceCar) { }
                else if (_priceMinCar <= c.PriceCar && _priceMaxCar >= c.PriceCar) { }
                else
                    continue;

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

                if (_engineMinAmount == 0 && _priceMaxCar == 0) { }
                else if (_engineMinAmount <= c.EngineAmountCar && _engineMaxAmount == 0) { }
                else if (_engineMinAmount == 0 && _engineMaxAmount >= c.EngineAmountCar) { }
                else if (_engineMinAmount <= c.EngineAmountCar && _engineMaxAmount >= c.EngineAmountCar) { }
                else
                    continue;

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
