using System;
using System.Globalization;
using Xamarin.Forms;

namespace TripLog.Converters
{
    /*
     * For Android add images to Resources/drawable
     * For UWP add images to main folder(!) TripLog.UWP
     * For iOS ...
     * 
     * In .NET MAUI one resource folder is needed for multiple platforms
     */
    public class RatingToStarImageNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int rating)
            {
                if (rating <= 1)
                {
                    return "star_1" + ".png";
                }
                if (rating >= 5)
                {
                    return "stars_5" + ".png";
                }
                return "stars_" + rating + ".png";
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
