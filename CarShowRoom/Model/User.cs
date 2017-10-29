using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CarShowRoom.Model
{
    class User
    {
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

        public enum RegionUsers
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

        public enum Auto
        {
            Новое,
            Старое
        }

        public string Phone { get; set; }

        /* Область */
        public RegionUsers RegionUser { get; set; }

        /* Город */
        public string City { get; set; }

        /* Максимальная цена авто */
        public int MaxMoney { get; set; }

        public Auto ReqAuto { get; set; }

        /* Req - requirenment */
        public string ReqMark { get; set; }

        /* Год выпуска */
        public int ReqYear { get; set; }

        /* Обьем двигателя*/
        public float ReqEngineAmount { get; set; }

        /* Тип двигателя */
        public EngineTypeCars ReqEngineType { get; set; }

        /* КПП */
        public TransmissionCars ReqTransmission { get; set; }

        /* Тип кузова */
        public BodyTypeCars ReqBodyType { get; set; }
    }
}