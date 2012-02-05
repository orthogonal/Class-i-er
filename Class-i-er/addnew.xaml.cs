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
        int i = 0;
        public addnew()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (NavigationContext.QueryString.TryGetValue("start", out starttime
            if (NavigationContext.QueryString.TryGetValue("selectedItem", out selectedIndex))
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ClassItem newItem = new ClassItem();
            newItem.className = textBox1.Text;
            newItem.classCode = textBox2.Text;
            MainPage.mydatabase.ClassItems.InsertOnSubmit(newItem);
            MainPage.mydatabase.SubmitChanges();
            NavigationService.Navigate(new Uri("/schedule.xaml", UriKind.Relative));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TimeSelection.xaml", UriKind.Relative));
        }
    }

    
}