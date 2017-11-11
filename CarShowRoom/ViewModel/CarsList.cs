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
    public class CarsList
    {
        /* Главная коллекция БД автомобилей */
        private static ObservableCollection<Car> carsList = new ObservableCollection<Car>();

        /* Свойство для получения коллекции carsList */
        public ObservableCollection<Car> CarList
        {
            get => carsList;
            set => carsList = value;
        }
    }
}