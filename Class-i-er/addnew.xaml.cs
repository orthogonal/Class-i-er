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
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Class_i_er
{
    public partial class addnew : PhoneApplicationPage
    {
        public addnew()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Boolean[] weekDays = new Boolean[7];
            Temporary newItem = new Temporary();
            String starttime = "";

            if (NavigationContext.QueryString.TryGetValue("start", out starttime) == true)
            {
                newItem.day = 1;
                newItem.start = Convert.ToInt16(starttime);
                MainPage.mydatabase.Temps.InsertOnSubmit(newItem);
                MainPage.mydatabase.SubmitChanges();
            }
            else
            {
                var deleteIt = (from c in MainPage.mydatabase.Temps select c);
                foreach (var row in deleteIt) MainPage.mydatabase.Temps.DeleteOnSubmit(row);
                MainPage.mydatabase.SubmitChanges();
            }

            var tempids = (from c in MainPage.mydatabase.Temps
                            select c.id);
            foreach (int id in tempids)
            {
                TextBox foo = new TextBox();
                var daysel = (from c in MainPage.mydatabase.Temps where c.id == id select c.day);
                var startsel = (from c in MainPage.mydatabase.Temps where c.id == id select c.start);
                foreach (int day in daysel)
                {
                    foreach (int start in startsel)
                    {
                        foo.Text = " " + day + "\n\r" + start;
                        foo.Width = 240;
                        foo.Height = 200;
                        foo.Background = new SolidColorBrush(Colors.Blue);
                        listBox1.Items.Add(foo);
                    }
                }
            }
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