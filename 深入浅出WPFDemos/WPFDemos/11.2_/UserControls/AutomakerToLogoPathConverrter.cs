using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace _11._2_.UserControls
{
    //厂商名称转换为Logo图片路径
    public class AutomakerToLogoPathConverrter : IValueConverter
    {
        //正向转换
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string uriStr = string.Format(@"/Resources/Logos/{0}.png", (string)value);
            return new BitmapImage(new Uri(uriStr, UriKind.Relative));
        }

        //未被用到
        public object ConvertBack(Object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
