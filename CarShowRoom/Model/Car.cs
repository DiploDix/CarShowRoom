using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CarShowRoom.Model
{
    public class Car
    {
        public string HowCar { get; set; }

        /* Состояние авто(бу, новое) */
        public string StateCar { get; set; }

        /* Отечественное или иностранное авто */
        public string AbroadCar { get; set; }

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
        public string EngineTypeCar { get; set; }

        /* КПП */
        public string TransmissionCar { get; set; }

        /* Тип кузова */
        public string BodyTypeCar { get; set; }

        /* Область */
        public string RegionCar { get; set; }

        /* Город */
        public string CityCar { get; set; }
    }
}
