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
using System.Windows.Media.Imaging;

namespace Class_i_er
{
    public partial class PivotPage1 : PhoneApplicationPage
    {
        public PivotPage1()
        {
            InitializeComponent();
            
            PivotItem[] daysPanels = new PivotItem[7];
            for (int i = 0; i < 7; i++)
            {
                daysPanels[i] = new PivotItem();
                daysPanels[i].Width = 456;
                Grid baseGrid = new Grid();
                ListBox classList = new ListBox();
                baseGrid.Children.Add(classList);
                SolidColorBrush backgroundBrush = new SolidColorBrush(Colors.Blue);
                Color lightBlue = new Color();
                //FF00BFFF
                lightBlue.R  = 0;
                lightBlue.G = 191;
                lightBlue.B = 255;
                backgroundBrush.Color = lightBlue;
                

                //Add Weekend Text
                bool noClasses = true; //temporary
                if (noClasses && (i==0 || i==6))
                {
                    BitmapImage bi = new BitmapImage(new Uri("weekendimage.jpg", UriKind.Relative));
                    ImageBrush ib = new ImageBrush();
                    ib.ImageSource = bi;
                    daysPanels[i].Background = ib;
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
                //classList.Background = backgroundBrush;
                //baseGrid.Background = backgroundBrush;
                //daysPanels[i].Background = backgroundBrush;
                //daysPanels[i].Content = baseGrid;
                
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
            
        }
    }
}