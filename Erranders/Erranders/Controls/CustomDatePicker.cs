using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Erranders.Controls
{
    public class CustomDatePicker : DatePicker
    {
        public static readonly BindablePropertyKey BorderColorPropertyKey = BindableProperty.CreateReadOnly("BorderColor",
                  typeof(Color),
                  typeof(CustomDatePicker),
                  Color.White);

        public static readonly BindablePropertyKey PlaceholderColorPropertyKey = BindableProperty.CreateReadOnly("PlaceholderColor",
                  typeof(Color),
                  typeof(CustomDatePicker),
                  Color.White);

        public static readonly BindableProperty PlaceholderColorProperty = PlaceholderColorPropertyKey.BindableProperty;

        public static readonly BindableProperty EnterTextProperty = BindableProperty.Create(propertyName: "Placeholder",
            returnType: typeof(string), declaringType:
            typeof(CustomDatePicker),
            defaultValue: default(string));

        public string Placeholder
        {
            get;
            set;
        }

        public static readonly BindableProperty BorderColorProperty = BorderColorPropertyKey.BindableProperty;

        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        private Color PlaceholderColor
        {
            get { return (Color)GetValue(PlaceholderColorProperty); }
            set { SetValue(PlaceholderColorProperty, value); }
        }
    }
}
