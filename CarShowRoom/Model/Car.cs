using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CarShowRoom.Model
{
    class Car : INotifyPropertyChanged
    {
        public enum StateCars
        {
            Отличное,
            Хорошее,
            Нормальное,
            Удовлетворительно,
            Ужасно
        };

        public enum AbroadCars
        {
            Отечественные,
            Зарубежные
        }

        public enum EngineTypeCars
        {
            Бензин,
            Дизель,
            Электро,
            Гибрид,
            Газ
        }

        public enum TransmissionCars
        {
            Автомат,
            Механика,
            Типтроник,
            Адаптивная,
            Вариатор
        }

        public enum BodyTypeCars
        {
            Универсал,
            Седан,
            Хэтчбек,
            Внедорожник,
            Купе,
            Кабриолет,
            Минивэн,
            Пикап
        }

        public enum RegionCars
        {
            Винницкая,
            Волынская,
            Днепропетровская,
            Донецка,
            Житомирская,
            Закарпатская,
            Запорожская,
            Ивано_Франковская,
            Киевская,
            Кировоградская,
            ЛуганскаяЛьвовская,
            Николаевская,
            Одесская,
            Полтавска,
            Республика_Крым,
            Ровенская,
            Сумская,
            Тернопольская,
            Харьковская,
            Херсонская,
            Хмельницкая,
            Черкасская,
            Черниговская,
            Черновицкая
        }

        /* Состояние авто(бу, новое) */
        public StateCars State { get; set; }

        /* Отечественное или иностранное авто */
        public AbroadCars AbroadCar { get; set; }

        /* Марка авто */
        public string MarkCar { get; set; }

        /* Модель авто */
        public string ModelCar { get; set; }

        /* Цена грн */
        public int PriceCar { get; set; }

        /* Год выпуска */
        public int YearCar { get; set; }

        /* Обьем двигателя*/
        public float EngineAmountCar { get; set; }

        /* Тип двигателя */
        public EngineTypeCars EngineTypeCar { get; set; }

        /* КПП */
        public TransmissionCars TransmissionCar { get; set; }

        /* Тип кузова */
        public BodyTypeCars BodyTypeCar { get; set; }

        /* Область */
        public RegionCars RegionCar { get; set; }

        /* Город */
        public string CityCar { get; set; }

        public static ObservableCollection<Car> carsList = new ObservableCollection<Car>();

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
