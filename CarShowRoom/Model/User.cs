namespace CarShowRoom.Model
{
    public class User
    {
        /* Номер телефона */
        public string Phone { get; set; }

        /* бу, новое*/
        public string UsedOrNewUser { get; set; }

        /* Состояние авто */
        public string StateUser { get; set; }

        /* Отечественное или иностранное авто */
        public string ProductionUser { get; set; }

        /* Марка авто */
        public string MarkUser { get; set; }

        /* Модель авто */
        public string ModelUser { get; set; }

        /* Минимальная цена грн */
        public int PriceMinUser { get; set; }

        /* максимальная цена грн */
        public int PriceMaxUser { get; set; }

        /* Год выпуска от */
        public int YearMinUser { get; set; }

        /* Год выпуска до*/
        public int YearMaxUser { get; set; }

        /* Минимальный обьем двигателя*/
        public float EngineAmountMinUser { get; set; }

        /* Максимальный обьем двигателя*/
        public float EngineAmountMaxUser { get; set; }

        /* Тип топлива */
        public string FuelUser { get; set; }

        /* КПП */
        public string TransmissionUser { get; set; }

        /* Тип кузова */
        public string BodyTypeUser { get; set; }

        /* Область */
        public string RegionUser { get; set; }

        /* Город */
        public string CityUser { get; set; }
    }
}