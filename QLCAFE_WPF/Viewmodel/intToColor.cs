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
                    return "Blue";
                    
                case 1:
                    return "Red";
                default:
                    return "Blue";
            }
            
            return "Black";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
