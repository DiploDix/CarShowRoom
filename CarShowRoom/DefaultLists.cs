using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowRoom
{
    /// <summary>
    /// Списки
    /// </summary>
    class DefaultLists
    {
        private List<string> getListUsedOrNewCar = new List<string>(new string[] { "Новое", "Б/у" });
        private List<string> getListState = new List<string>(new string[] { "Отличное", "Хорошее", "Нормальное", "Удовлетворительное", "Ужасное" });
        private List<string> getListProduction = new List<string>(new string[] { "Отечественные", "Зарубежные" });
        private List<string> getListFuelType = new List<string>(new string[] { "Бензин", "Дизель", "Электро", "Гибрид", "Газ" });
        private List<string> getListTransmission = new List<string>(new string[] { "Автомат", "Механика", "Типтроник", "Адаптивная", "Вариатор", });
        private List<string> getListBodyType = new List<string>(new string[] { "Универсал", "Седан", "Хэтчбек", "Внедорожник", "Купе", "Кабриолет", "Минивэн", "Пикап" });
        private List<string> getListRegion = new List<string>(new string[] {
        "Винницкая",
        "Волынская",
        "Днепропетровская",
        "Донецкая",
        "Житомирская",
        "Закарпатская",
        "Запорожская",
        "Ивано-Франковская",
        "Киевская",
        "Кировоградская",
        "Луганская",
        "Львовская",
        "Николаевская",
        "Одесская",
        "Полтавска",
        "Республика Крым",
        "Ровенская",
        "Сумская",
        "Тернопольская",
        "Харьковская",
        "Херсонская",
        "Хмельницкая",
        "Черкасская",
        "Черниговская",
        "Черновицкая" });


        public List<string> ListUsedOrNewCar => getListUsedOrNewCar;
        public List<string> ListState => getListState;
        public List<string> ListProduction => getListProduction;
        public List<string> ListFuelType => getListFuelType;
        public List<string> ListTransmission => getListTransmission;
        public List<string> ListBodyType => getListBodyType;
        public List<string> ListRegion => getListRegion;


        private List<string> getListUsedOrNewCarAll = new List<string>(new string[] { "Все", "Новое", "Б/у" });
        private List<string> getListStateAll = new List<string>(new string[] { "Все", "Отличное", "Хорошее", "Нормальное", "Удовлетворительное", "Ужасное" });
        private List<string> getListProductionAll = new List<string>(new string[] { "Все", "Отечественные", "Зарубежные" });
        private List<string> getListFuelTypeAll = new List<string>(new string[] { "Все", "Бензин", "Дизель", "Электро", "Гибрид", "Газ" });
        private List<string> getListTransmissionAll = new List<string>(new string[] { "Все", "Автомат", "Механика", "Типтроник", "Адаптивная", "Вариатор", });
        private List<string> getListBodyTypeAll = new List<string>(new string[] { "Все", "Универсал", "Седан", "Хэтчбек", "Внедорожник", "Купе", "Кабриолет", "Минивэн", "Пикап" });
        private List<string> getListRegionAll = new List<string>(new string[] {
        "Все",
        "Винницкая",
        "Волынская",
        "Днепропетровская",
        "Донецкая",
        "Житомирская",
        "Закарпатская",
        "Запорожская",
        "Ивано-Франковская",
        "Киевская",
        "Кировоградская",
        "Луганская",
        "Львовская",
        "Николаевская",
        "Одесская",
        "Полтавска",
        "Республика Крым",
        "Ровенская",
        "Сумская",
        "Тернопольская",
        "Харьковская",
        "Херсонская",
        "Хмельницкая",
        "Черкасская",
        "Черниговская",
        "Черновицкая" });


        public List<string> ListUsedOrNewCarAll => getListUsedOrNewCarAll;
        public List<string> ListStateAll => getListStateAll;
        public List<string> ListProductionAll => getListProductionAll;
        public List<string> ListFuelTypeAll => getListFuelTypeAll;
        public List<string> ListTransmissionAll => getListTransmissionAll;
        public List<string> ListBodyTypeAll => getListBodyTypeAll;
        public List<string> ListRegionAll => getListRegionAll;
    }
}
