﻿#pragma checksum "C:\Users\thiagodasilva\Downloads\Fitness\Fitness\Fitness\Pages\PageImc.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FB2CAC933BDA3D387CA51AD72F447EF7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using C1.Phone.Gauge;
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


namespace Fitness.Pages {
    
    
    public partial class PageImc : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox txtPeso;
        
        internal System.Windows.Controls.TextBox txtPesoIdade;
        
        internal C1.Phone.Gauge.C1LinearGauge c1lg1;
        
        internal System.Windows.Controls.TextBlock Msg;
        
        internal System.Windows.Controls.TextBox txtAltura;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Fitness;component/Pages/PageImc.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.txtPeso = ((System.Windows.Controls.TextBox)(this.FindName("txtPeso")));
            this.txtPesoIdade = ((System.Windows.Controls.TextBox)(this.FindName("txtPesoIdade")));
            this.c1lg1 = ((C1.Phone.Gauge.C1LinearGauge)(this.FindName("c1lg1")));
            this.Msg = ((System.Windows.Controls.TextBlock)(this.FindName("Msg")));
            this.txtAltura = ((System.Windows.Controls.TextBox)(this.FindName("txtAltura")));
        }
    }
}

