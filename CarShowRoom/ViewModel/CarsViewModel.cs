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

        /* Получаем коллекцию автомобилей */
        ObservableCollection<Car> car = new CarsList().CarList;

        public CarsViewModel() { }

        /* Вывод коллекцию в datagridview carGrid */
        public ObservableCollection<Car> GetListCar
        {
            get => car;
            set
            {
                car = value;
                OnPropertyChanged("carGrid");
            }
        }

        //public IEnumerable<string> GetListState => Enum.GetNames(typeof(State));

        /* Событие изменения свойства */
        public event PropertyChangedEventHandler PropertyChanged;

        /* Метод изменения свойства */
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

    }
}