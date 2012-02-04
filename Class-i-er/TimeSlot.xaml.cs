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
    public partial class TimeSlot : PhoneApplicationPage
    {
        public TimeSlot()
        {
            InitializeComponent();
            List<DayofWeek> source = new List<DayofWeek>();
            source.Add(new DayofWeek("Monday"));
            source.Add(new DayofWeek("Tuesday"));
            source.Add(new DayofWeek("Test Day"));
            this.listPicker1.ItemsSource = source;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/addnew.xaml?day=Monday&start=720&end=840", UriKind.Relative));
        }
    }

    public class DayofWeek
    {
        public DayofWeek(String name1)
        {
            name = name1;
        }
        public String name { get; set; }
    }
}