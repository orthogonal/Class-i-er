using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Class_i_er
{
    public partial class schedule : PhoneApplicationPage
    {
        public schedule()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/addnew.xaml", UriKind.Relative));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var foo = (from c in MainPage.mydatabase.ClassItems
                               select c.className
                              );
            String text1 = "";
            int i = 0;
            foreach (String s in foo)
            {
                if (i > 0) text1 += " ";
                text1 += s;
                i++;
            }
            button1.Content = text1;
        }
    }
}