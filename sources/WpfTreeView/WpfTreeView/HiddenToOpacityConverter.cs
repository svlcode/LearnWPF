using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;

namespace WpfTreeView
{
    [ValueConversion(typeof(string), typeof(double))]
    public class HiddenToOpacityConverter : IValueConverter
    {
        public static HiddenToOpacityConverter Instance = new HiddenToOpacityConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var path = value as string;
            if (string.IsNullOrEmpty(path))
                return null;

            var opacity = 1.0;
            if (new FileInfo(path).Attributes.HasFlag(FileAttributes.Hidden))
            {
                opacity = 0.3;
            }

            return opacity;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}