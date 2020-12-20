using System;
using System.Globalization;
using System.Windows.Data;

namespace MachineTracker
{
    class SerialStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {  
            return value.ToString().Split(' ', 2)[0];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
