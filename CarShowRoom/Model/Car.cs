namespace CarShowRoom.Model
{
    public class Car
    {
        /*  бу, новое */
        public string UsedOrNewCar { get; set; }

        /* Состояние авто */
        public string StateCar { get; set; }

        /* Отечественное или иностранное авто */
        public string ProductionCar { get; set; }

        /* Марка авто */
        public string MarkCar { get; set; }

        /* Модель авто */
        public string ModelCar { get; set; }

        /* Минимальная цена грн */
        public int PriceCar { get; set; }

        /* Год выпуска от */
        public int YearCar { get; set; }

        /* Минимальный обьем двигателя*/
        public float EngineAmountCar { get; set; }

        /* Тип топлива */
        public string FuelCar { get; set; }

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
