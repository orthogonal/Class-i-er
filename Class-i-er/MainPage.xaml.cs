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
using System.IO.IsolatedStorage;

namespace Class_i_er
{
    public partial class MainPage : PhoneApplicationPage
    {
        IsolatedStorageSettings appSettings = IsolatedStorageSettings.ApplicationSettings;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            if (!appSettings.Contains("firstTime"))
                appSettings.Add("firstTime", true);
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            if (((bool)appSettings["firstTime"]) == true)
                //? means "make it nullable"
                //?? means "if it's nothing, make it true"
                //skip the first page
                this.NavigationService.Navigate(new Uri("/Init.xaml", UriKind.Relative));
            else
                this.NavigationService.Navigate(new Uri("/schedule.xaml", UriKind.Relative));
        }
    }
}