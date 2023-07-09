using System;
using System.Globalization;
using System.Windows.Data;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Editors.Settings;

namespace DevExpressProgressBarDemo
{
    public class BooleanToProgressBarConverter : IValueConverter
    {
        protected ProgressBarMarqueeStyleSettings _marquee = new ProgressBarMarqueeStyleSettings();
        protected ProgressBarStyleSettings _normal = new ProgressBarStyleSettings();

        protected ProgressBarEditSettings _progressBarEditSettings;

        public BooleanToProgressBarConverter()
        {
            _progressBarEditSettings = new ProgressBarEditSettings();
            _progressBarEditSettings.StyleSettings = _normal;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool) value)
            {
                _progressBarEditSettings.StyleSettings = _marquee;
            }
            _progressBarEditSettings.StyleSettings = _normal;
            return _progressBarEditSettings;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}