﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Erranders.Controls
{
    public class CustomViewCell : ViewCell
    {
        public static readonly BindableProperty SelectedBackgroundColorProperty =
        BindableProperty.Create("SelectedBackgroundColor",
                                typeof(Color),
                                typeof(CustomViewCell),
                                Color.Default);

        public Color SelectedBackgroundColor
        {
            get { return (Color)GetValue(SelectedBackgroundColorProperty); }
            set { SetValue(SelectedBackgroundColorProperty, value); }
        }
    }
}
