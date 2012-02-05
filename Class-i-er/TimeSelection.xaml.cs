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
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
            
        }

        private void day_click(object sender, RoutedEventArgs e)
        {
            Button day = sender as Button;





            if (day.Opacity == 100)
            {
                day.Background = new SolidColorBrush(Colors.White);
                day.Opacity = 99;
            }
            else
            {
                day.Background = new SolidColorBrush(Colors.Black);
                day.Opacity = 100;
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[] days = new int[7];
            for (int i = 0; i < 7; i++) days[i] = 0;
            if (sun.Opacity == 99) days[0] = 1;
            if (mon.Opacity == 99) days[1] = 1;
            if (tue.Opacity == 99) days[2] = 1;
            if (wed.Opacity == 99) days[3] = 1;
            if (thu.Opacity == 99) days[4] = 1;
            if (fri.Opacity == 99) days[5] = 1;
            if (sat.Opacity == 99) days[6] = 1;
            NavigationService.Navigate(new Uri("/addnew.xaml?sun=" + days[0] + "&mon=" + days[1] + "&tue=" + days[2] + "&wed=" + days[3] + "&thu=" + days[4]
                + "&fri=" + days[5] + "&sat=" + days[6] + "&start=" + startTime.Value + "&finish=" + endTime.Value, UriKind.Relative));
        }
    }
}