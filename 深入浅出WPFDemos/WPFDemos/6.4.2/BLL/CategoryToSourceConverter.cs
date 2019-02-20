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
    public class CategoryToSourceConverter:IValueConverter
    {
        //将Category转换为URI
        public object Convert(object value,Type targetType,object parameter,CultureInfo culture)
        {
            Category c=(Category)value;
            switch (c)
            {
                case Category.Bomber:
                    return @"\Icons\Bomber.ico";
                case Category.Fighter:
                    return @"\Icons\Fighter.ico";
                default:
                    return null;
            }
        }

        //不会被调用
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
