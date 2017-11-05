﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CarShowRoom.Model
{
    public enum State
    {
        Отличное,
        Хорошее,
        Нормальное,
        Удовлетворительно,
        Ужасно
    }


    public enum Abroad
    {
        Отечественные,
        Зарубежные
    }

    public enum EngineType
    {
        Бензин,
        Дизель,
        Электро,
        Гибрид,
        Газ
    }

    public enum Transmission
    {
        Автомат,
        Механика,
        Типтроник,
        Адаптивная,
        Вариатор
    }

    public enum BodyType
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
   
    public enum Region
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
        Луганская,
        Львовская,
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
}
