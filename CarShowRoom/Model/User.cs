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
        public string Phone { get; set; }

        /* Область */
        public Region RegionUser { get; set; }

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
        public EngineType ReqEngineType { get; set; }

        /* КПП */
        public Transmission ReqTransmission { get; set; }

        /* Тип кузова */
        public BodyType ReqBodyType { get; set; }

        public State ReqState { get; set; }
    }
}