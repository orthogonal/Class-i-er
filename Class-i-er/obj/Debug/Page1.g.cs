﻿#pragma checksum "c:\users\andrew\documents\visual studio 2010\Projects\Class-i-er\Class-i-er\Page1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F9E55E2535E98C7927C2AE5FDE194F27"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Class_i_er {
    
    
    public partial class Page1 : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid grid1;
        
        internal System.Windows.Controls.TextBlock welcomeLabel;
        
        internal System.Windows.Controls.TextBlock infoLabel;
        
        internal System.Windows.Controls.TextBlock nameLabel;
        
        internal System.Windows.Controls.TextBox nameBox;
        
        internal System.Windows.Controls.TextBlock schoolLabel;
        
        internal System.Windows.Controls.TextBox schoolBox;
        
        internal System.Windows.Controls.Button btnSubmit;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Class-i-er;component/Page1.xaml", System.UriKind.Relative));
            this.grid1 = ((System.Windows.Controls.Grid)(this.FindName("grid1")));
            this.welcomeLabel = ((System.Windows.Controls.TextBlock)(this.FindName("welcomeLabel")));
            this.infoLabel = ((System.Windows.Controls.TextBlock)(this.FindName("infoLabel")));
            this.nameLabel = ((System.Windows.Controls.TextBlock)(this.FindName("nameLabel")));
            this.nameBox = ((System.Windows.Controls.TextBox)(this.FindName("nameBox")));
            this.schoolLabel = ((System.Windows.Controls.TextBlock)(this.FindName("schoolLabel")));
            this.schoolBox = ((System.Windows.Controls.TextBox)(this.FindName("schoolBox")));
            this.btnSubmit = ((System.Windows.Controls.Button)(this.FindName("btnSubmit")));
        }
    }
}

