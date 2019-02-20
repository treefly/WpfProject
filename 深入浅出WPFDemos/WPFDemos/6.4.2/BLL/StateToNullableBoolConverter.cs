using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using static _6._4._2.MainWindow;

namespace _6._4._2.BLL
{
    public class StateToNullableBoolConverter:IValueConverter
    {
        //将State转换为bool
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            State s = (State)value;
            switch (s)
            {
                case State.Locked:
                    return false;
                case State.Available:
                    return true;
                case State.Unknown:
                default:
                    return null;
            }
        }

        //将bool?转换为State
        public object ConvertBack(object value,Type targetType,object parameter,CultureInfo culture)
        {
            bool? nb = (bool?)value;
            switch (nb)
            {
                case true:
                    return State.Available;
                case false:
                    return State.Locked;
                case null:
                default:
                    return State.Unknown;
            }
        }
    }
}
