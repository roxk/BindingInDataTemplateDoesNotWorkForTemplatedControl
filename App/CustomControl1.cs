using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace App
{
    public sealed class CustomControl1 : Control
    {
        public CustomControl1()
        {
            this.DefaultStyleKey = typeof(CustomControl1);
        }

        public double SomeProp
        {
            get { return (double) GetValue(SomePropProperty); }
            set { SetValue(SomePropProperty, value); }
        }
        public static readonly DependencyProperty SomePropProperty = DependencyProperty.Register(
            nameof(SomeProp), typeof(double), typeof(CustomControl1), new PropertyMetadata(0));
    }
}
