using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Erranders.Controls
{
    public class CustomEntry : Entry
    {
        public static readonly BindablePropertyKey BorderColorPropertyKey = BindableProperty.CreateReadOnly("BorderColor",
            typeof(Color),
            typeof(CustomEntry),
            Color.Black);

        public static readonly BindableProperty BorderColorProperty = BorderColorPropertyKey.BindableProperty;

        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        public static readonly BindableProperty PlaceHolderProperty = BindableProperty.Create(
            "Placeholder",
            typeof(string),
            typeof(CustomEntry),
            "");

        public string PlaceHolder
        {
            get
            {
                return (string)GetValue(PlaceHolderProperty);
            }
            set
            {
                SetValue(PlaceholderProperty, value);
            }
        }

    }
}
