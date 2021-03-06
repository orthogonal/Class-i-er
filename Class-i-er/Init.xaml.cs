﻿using System;
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
    public partial class Init : PhoneApplicationPage
    {
        IsolatedStorageSettings appSettings = IsolatedStorageSettings.ApplicationSettings;
        public Init()
        {
            InitializeComponent();  
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            appSettings["firstTime"] = false;
            NavigationService.Navigate(new Uri("/schedule.xaml", UriKind.Relative));
        }
    }
}