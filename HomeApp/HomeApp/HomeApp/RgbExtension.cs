using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xamarin.Forms.Xaml;

namespace HomeApp
{
    public class RgbExtension : IMarkupExtension
    {
        public int Red { set; get; }
        public int Green { set; get; }
        public int Blue { set; get; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Color.FromArgb(Red, Green, Blue);
        }
    }
}
