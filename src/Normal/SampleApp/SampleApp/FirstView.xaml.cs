using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace SampleApp
{
    public partial class FirstView : UserControl
    {
        public FirstView()
        {
            this.InitializeComponent();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            if (Btn.Content.Equals("Click Me"))
            {
                Btn.Content = "Hello world";
                return;
            }
            if (Btn.Content.Equals("Hello world"))
            {
                Btn.Content = "Click Me";
                return;
            }
        }
    }
}
