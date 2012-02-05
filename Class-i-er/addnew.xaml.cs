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
            String starttime = "";

            if (NavigationContext.QueryString.TryGetValue("start", out starttime) == true)
            {
                String[] days = new String[7];
                for (int i = 0; i < 7; i++) days[i] = "";
                String endtime = "";

                NavigationContext.QueryString.TryGetValue("finish", out endtime);
                NavigationContext.QueryString.TryGetValue("sun", out days[0]);
                NavigationContext.QueryString.TryGetValue("mon", out days[1]);
                NavigationContext.QueryString.TryGetValue("tue", out days[2]);
                NavigationContext.QueryString.TryGetValue("wed", out days[3]);
                NavigationContext.QueryString.TryGetValue("thu", out days[4]);
                NavigationContext.QueryString.TryGetValue("fri", out days[5]);
                NavigationContext.QueryString.TryGetValue("sat", out days[6]);

                for (int i = 0; i < 7; i++)
                {
                    if (days[i] == "1")
                    {
                        Temporary newItem = new Temporary();
                        newItem.day = i;
                        newItem.start = starttime;
                        MainPage.mydatabase.Temps.InsertOnSubmit(newItem);
                        MainPage.mydatabase.SubmitChanges();
                    }
                }
            }
            else
            {
                var deleteIt = (from c in MainPage.mydatabase.Temps select c);
                foreach (var row in deleteIt) MainPage.mydatabase.Temps.DeleteOnSubmit(row);
                MainPage.mydatabase.SubmitChanges();
            }

            String[] dayNames = new String[7];
            dayNames[0] = "Sunday";
            dayNames[1] = "Monday";
            dayNames[2] = "Tuesday";
            dayNames[3] = "Wednesday";
            dayNames[4] = "Thursday";
            dayNames[5] = "Friday";
            dayNames[6] = "Saturday";

            var tempids = (from c in MainPage.mydatabase.Temps
                            select c.id);
            foreach (int id in tempids)
            {
                TextBox foo = new TextBox();
                IEnumerable<int> daysel = (from c in MainPage.mydatabase.Temps where c.id == id select c.day);
                var startsel = (from c in MainPage.mydatabase.Temps where c.id == id select c.start);
                var finishsel = (from c in MainPage.mydatabase.Temps where c.id == id select c.finish);
                foreach (int day in daysel)
                {
                    foreach (String start in startsel)
                    {
                        foreach (String finish in finishsel)
                        {
                            foo.Text = " " + dayNames[day] + "\n\r" + start + "\n\r to \n\r" + finish;
                            foo.Width = 240;
                            foo.Height = 200;
                            foo.Background = new SolidColorBrush(Colors.Blue);
                            listBox1.Items.Add(foo);
                        }
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
            int id = (from c in MainPage.mydatabase.ClassItems where c.className == newItem.className select c.id).FirstOrDefault();
            IEnumerable<Temporary> selection = (from c in MainPage.mydatabase.Temps select c);
            foreach(Temporary row in selection)
            {
                ClassTime newTime = new ClassTime();
                newTime.day = row.day;
                newTime.id = id;
                newTime.start = row.start;
                newTime.finish = row.finish;
                MainPage.mydatabase.ClassTimes.InsertOnSubmit(newTime);
                MainPage.mydatabase.SubmitChanges();
            }
            NavigationService.Navigate(new Uri("/schedule.xaml", UriKind.Relative));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TimeSelection.xaml", UriKind.Relative));
        }
    }

    
}