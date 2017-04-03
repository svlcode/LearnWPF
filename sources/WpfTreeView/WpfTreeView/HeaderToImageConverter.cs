using System;
using System.Globalization;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace WpfTreeView
{

    [ValueConversion(typeof(string), typeof(BitmapImage))]
    public class HeaderToImageConverter : IValueConverter
    {
        public static HeaderToImageConverter Instance = new HeaderToImageConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var path = value as string;
            if (string.IsNullOrEmpty(path))
                return null;

            var image = "Images/blank-file.png";

            
            if (IsPathDrive(path))
            {
                image = "Images/drive.png";
            }
            else if(new FileInfo(path).Attributes.HasFlag(FileAttributes.Directory))
            {
                image = "Images/closed-folder.png";
            }

            var uri = new Uri($"pack://application:,,,/{image}");


            return new BitmapImage(uri);
        }

        private bool IsPathDrive(string path)
        {
            return path.Length == 3 && path.EndsWith("\\");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}