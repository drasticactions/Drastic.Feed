﻿// <copyright file="BooleanToVisibilityInverter.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;

namespace Drastic.Feed.UI.WinUI
{
    public class BooleanToVisibilityInverter : IValueConverter
    {
        /// <inheritdoc/>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is not bool realValue)
            {
                return Visibility.Collapsed;
            }

            return realValue ? Visibility.Collapsed : Visibility.Visible;
        }

        /// <inheritdoc/>
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}