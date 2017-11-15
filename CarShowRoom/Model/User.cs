namespace CarShowRoom.Model
{
    public class User
    {
        public string Phone { get; set; }

        /* Область */
        public string RegionUser { get; set; }

        /* Город */
        public string City { get; set; }

        /* Максимальная цена авто */
        public int MaxMoney { get; set; }

        public string ReqAuto { get; set; }

        /* Req - requirenment */
        public string ReqMark { get; set; }

        /* Год выпуска */
        public int ReqYear { get; set; }

        /* Обьем двигателя*/
        public float ReqEngineAmount { get; set; }

        /* Тип двигателя */
        public string ReqEngineType { get; set; }

        /* КПП */
        public string ReqTransmission { get; set; }

        /* Тип кузова */
        public string ReqBodyType { get; set; }

        public string ReqState { get; set; }
    }
}