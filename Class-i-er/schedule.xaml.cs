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

            PivotItem[] daysPanels = new PivotItem[7];
            for (int i = 0; i < 7; i++)
            {
                daysPanels[i] = new PivotItem();
                Grid baseGrid = new Grid();
                ListBox classList = new ListBox();
                baseGrid.Children.Add(classList);

                //Add Weekend Text
                bool noClasses = true; //temporary
                if (noClasses && (i == 0 || i == 6))
                {
                    //    ImageSource WKsource = "weekendimage.jpg";
                    //    ImageBrush weekendBrush = new ImageBrush();
                    //    weekendBrush.ImageSource = WKsource;
                    //    weekendBrush.Stretch = "Fill";
                    //    baseGrid.Background = weekendBrush;
                }

                // If classes exist in the schedule database, add them now to the schedule grid
                /*bool noclasses=false; //tempoary
                if (noclasses)
                {
                    Button addClass = new Button();
                    addClass.Width = 170;
                    addClass.Height = 72;
                    addClass.Content = "Add Class";
                    baseGrid.Children.Add(addClass);
                }*/
                daysPanels[i].Content = baseGrid;
            }

            daysPanels[0].Header = "Sunday";
            daysPanels[1].Header = "Monday";
            daysPanels[2].Header = "Tuesday";
            daysPanels[3].Header = "Wednesday";
            daysPanels[4].Header = "Thursday";
            daysPanels[5].Header = "Friday";
            daysPanels[6].Header = "Saturday";




            for (int i = 0; i < 7; i++)
            {
                Piv.Items.Add(daysPanels[i]);
            }

            IEnumerable<ClassTime> selection = (from c in MainPage.mydatabase.ClassTimes select c);
            foreach (ClassTime row in selection)
            {
                TextBox foo = new TextBox();
                var namesel = (from c in MainPage.mydatabase.ClassItems where c.id == row.id select c.className);
                var codesel = (from c in MainPage.mydatabase.ClassItems where c.id == row.id select c.classCode);

                foreach (String name in namesel)
                {
                    foreach (String code in codesel)
                    {

                        foo.Text = " " + name + "\n\r" + code;
                        foo.Width = 440;
                        foo.Height = 200;
                        foo.Background = new SolidColorBrush(Colors.Blue);
                        ((ListBox)((Grid)daysPanels[row.day].Content).Children[0]).Items.Add(foo);
                    }
                }
            }
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/addnew.xaml", UriKind.Relative));
        }
    }
}