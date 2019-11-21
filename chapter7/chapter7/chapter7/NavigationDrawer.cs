﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace chapter7
{
    public class zNavigationDrawer : MasterDetailPage  // Navigation Drawer using MasterDetailPage
    {
        public zNavigationDrawer()
        {
            Title = "Navigation Drawer Using MasterDetailPage";
            string[] myPageNames = { "Home", "Second", "Third" };

            ListView listView = new ListView
            {
                ItemsSource = myPageNames,
            };
            this.Master = new ContentPage
            {
                Title = "Options",
                Content = listView,
                Icon = "hamburger.png"
            };

            listView.ItemTapped += (sender, e) =>
            {
                ContentPage gotoPage;
                switch (e.Item.ToString())
                {
                    case "Home":
                        gotoPage = new HomePage();
                        break;
                    case "Second":
                        gotoPage = new SecondPage();
                        break;
                    case "Third":
                        gotoPage = new ThirdPage();
                        break;
                    default:
                        gotoPage = new NavigationPage1();
                        break;
                }
                Detail = new NavigationPage(gotoPage);
                ((ListView)sender).SelectedItem = null;
                this.IsPresented = false;
            };

            Detail = new NavigationPage(new HomePage());
        }
    }
}
