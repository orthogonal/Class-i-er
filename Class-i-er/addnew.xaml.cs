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
    public partial class addnew : PhoneApplicationPage
    {
        public addnew()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            String input = textBox1.Text;
            ClassItem newItem = new ClassItem();
            newItem.endTime = 5000;
            newItem.startTime = 0;
            newItem.className = input;
            MainPage.mydatabase.ClassItems.InsertOnSubmit(newItem);
            MainPage.mydatabase.SubmitChanges();
            NavigationService.Navigate(new Uri("/schedule.xaml", UriKind.Relative));
        }
    }

    
}