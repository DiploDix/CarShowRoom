using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowRoom
{
    class DefaultLists
    {
        private List<string> getListAuto = new List<string>(new string[] { "Новое", "Б/у" });
        private List<string> getListState = new List<string>(new string[] { "Отличное", "Хорошее", "Нормальное", "Удовлетворительное", "Ужасное" });
        private List<string> getListAbroad = new List<string>(new string[] { "Отечественные", "Зарубежные" });
        private List<string> getListEngineType = new List<string>(new string[] { "Бензин", "Дизель", "Электро", "Гибрид", "Газ" });
        private List<string> getListTransmission = new List<string>(new string[] { "Автомат", "Механика", "Типтроник", "Адаптивная", "Вариатор", });
        private List<string> getListBodyTypeCars = new List<string>(new string[] { "Универсал", "Седан", "Хэтчбек", "Внедорожник", "Купе", "Кабриолет", "Минивэн", "Пикап" });
        private List<string> getListRegionCars = new List<string>(new string[] {
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


        public List<string> ListAuto => getListAuto;
        public List<string> ListState => getListState;
        public List<string> ListAbroad => getListAbroad;
        public List<string> ListEngineType => getListEngineType;
        public List<string> ListTransmission => getListTransmission;
        public List<string> ListBodyTypeCars => getListBodyTypeCars;
        public List<string> ListRegionCars => getListRegionCars;
    }
}
