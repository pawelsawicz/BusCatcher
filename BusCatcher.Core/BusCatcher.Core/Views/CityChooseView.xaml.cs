using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace BusCatcher.Core.Views
{
    public partial class CityChooseView : PhoneApplicationPage
    {
        public CityChooseView()
        {
            InitializeComponent();
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Terminate();
        }

        private void cityTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var city  = "";
            NavigationService.Navigate(new Uri("", UriKind.Relative));
        }
    }
}