﻿using System.Globalization;
using Avalonia.Data.Converters;

namespace ColorPicker.Converters;

internal class BoolToInvertedBoolConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is bool boolValue)
            return !boolValue;
        return false;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException("ConvertBack() of BoolToInvertedBoolConverter is not implemented");
    }
}