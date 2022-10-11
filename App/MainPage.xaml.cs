using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly ObservableCollection<string> Sources = new ObservableCollection<string>();
        public double SomeProp
        {
            get { return (double)GetValue(SomePropProperty); }
            set { SetValue(SomePropProperty, value); }
        }
        public static readonly DependencyProperty SomePropProperty = DependencyProperty.Register(
            nameof(SomeProp), typeof(double), typeof(MainPage), new PropertyMetadata(0));

        public MainPage()
        {
            this.InitializeComponent();
            Sources.Add("1");
            Sources.Add("2");
            Sources.Add("3");
            SomeProp = 100;
            for (var i = 0; i < 3; ++i)
            {
                var border = template.LoadContent() as CustomControl1;
                border.DataContext = "doesn't matter";
                border.SetValue(Canvas.LeftProperty, 0);
                border.SetValue(Canvas.TopProperty, 80 * i);
                border.Width = 500;
                border.Height = 80;
                container.Children.Add(border);
            }
        }
    }
}
