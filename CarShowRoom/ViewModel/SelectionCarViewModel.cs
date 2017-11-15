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


        public SelectionCarViewModel()
        {
            defCar = cars.CarList;
        }

        public void SelectionCar(User u)
        {
            defCar = cars.CarList;
            _usedOrNewCar = String.IsNullOrEmpty(u.ReqAuto) ? "Все" : u.ReqAuto;
            _stateCar = String.IsNullOrEmpty(u.ReqState) ? "Все" : u.ReqState;
            _producerCar = "Все";
            _engineTypeCar = String.IsNullOrEmpty(u.ReqEngineType) ? "Все" : u.ReqEngineType;
            _transmissionCar = String.IsNullOrEmpty(u.ReqTransmission) ? "Все" : u.ReqTransmission;
            _typeCar = String.IsNullOrEmpty(u.ReqBodyType) ? "Все" : u.ReqBodyType;
            _regionCar = String.IsNullOrEmpty(u.RegionUser) ? "Все" : u.RegionUser;
            _markCar = String.IsNullOrEmpty(u.ReqMark) ? "" : u.ReqMark;
            _modelCar = "";
            _yearCar = u.ReqYear == 0 ? 0 : u.ReqYear;
            _priceCar = u.MaxMoney;
            _engineAmount = u.ReqEngineAmount;
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
