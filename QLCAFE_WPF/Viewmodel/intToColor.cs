using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace QLCAFE_WPF.Viewmodel
{
    public class intToColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            
            switch (Int32.Parse(value.ToString())%2)
            {
                case 0:
                    return "Cornsilk";
                    
                case 1:
                    return "White";
                default:
                    return "White";
            }
            
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
