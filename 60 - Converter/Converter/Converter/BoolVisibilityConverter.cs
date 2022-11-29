using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Converter
{
    //tu warto coś napisać o kolejności konwertowania
    // czyli z czego konwertujemu => do czego

    [ValueConversion(typeof(bool),typeof(Visibility))]
    class BoolVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isVisible = (bool)value;
            if (isVisible == true) // dla pewności warto dopisać przypisanie "==true"
                return Visibility.Visible;
            else
                return Visibility.Collapsed;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // pierwsza konwersja poniżej nie jest potrzebna!!

            //  throw new NotImplementedException();

            //jeśli była  by potrzebna konwersja w jedna i druga stronę to klepiemy to poniżej
            Visibility visibility = (Visibility)value;

            if (visibility == Visibility.Collapsed)
                return false;
            else
                return true;

            // można zwrócić null co by się nc nie działo

            // return null;
        }
    }
}
