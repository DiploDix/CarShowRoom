using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CarShowRoom.ViewModel
{
    class Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType.Name == "String")
            {
                switch (value.ToString())
                {
                    case "Ивано_Франковская":
                        return value.ToString().Replace("_", "-");
                    default:
                        return value.ToString().Replace("_", " ");
                }
            }

            IEnumerable<string> str = ((IEnumerable<string>)value).Select((x) =>
            {
                if (x == "Ивано_Франковская")
                {
                    return x.Replace("_", "-");
                }
                return x.Replace("_", " ");
            });

            return str;
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value.ToString())
            {
                case "Ивано-Франковская":
                    return Enum.Parse(targetType, value.ToString().Replace("-", "_"));
                default:
                    break;
            }
            return Enum.Parse(targetType, value.ToString().Replace(" ", "_"));
        }

    }
}
