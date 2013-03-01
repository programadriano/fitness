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

namespace Fitness
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

       

        private void CalculoImc(object sender, MouseEventArgs e)
        {
            NavigationService.Navigate(
            new Uri("/Pages/PageImc.xaml", UriKind.Relative));
        }       

        private void CalculoTbm(object sender, MouseEventArgs e)
        {
            NavigationService.Navigate(
                        new Uri("/Pages/PageTmb.xaml", UriKind.Relative));
        }

        private void CalculoBf(object sender, MouseEventArgs e)
        {
            NavigationService.Navigate(
                        new Uri("/Pages/PageBf.xaml", UriKind.Relative));
        }
    }
}