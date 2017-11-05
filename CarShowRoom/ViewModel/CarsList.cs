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
        private static ObservableCollection<Car> carsList = new ObservableCollection<Car>();

        public ObservableCollection<Car> CarList
        {
            get
            {
                return carsList;
            }
            set
            {
                carsList = value;
            }
        }
    }
}